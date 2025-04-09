using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography.Image;

public class ImageEncoder:Encoder
{

    private ByteCollection _bytesRGB;

    private int _height;
    
    private int _width;

    private string _imagePath;
    
    public ImageEncoder(string imagePath,string content):base(imagePath)
    {
        this._content = content;
        this._imagePath = imagePath;
        this.SetRGB();
        
        TextAnalyzer textAnalyzer = new TextAnalyzer(_content);
        GraphCollection graphCollection = textAnalyzer.CreateGraphCollection();
        _key = new KeyImageDecoder().CreateKeyDecoder(graphCollection);
    }

    private void SetRGB()
    {
        Bitmap image = new Bitmap(this._imagePath);

        this._width = image.Width;
        this._height = image.Height;
        byte[] bytes = new byte[this._width * this._height * 3];
        int index = 0;

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixelColor = image.GetPixel(x, y);

                bytes[index++] = pixelColor.R;
                bytes[index++] = pixelColor.G;
                bytes[index++] = pixelColor.B;
            }
        }
        this._bytesRGB = new ByteCollection(bytes);
    }

    protected override void Encode()
    {        
        string contentEncoded = BinarizeContent();

        int index = 0;

        while (index < contentEncoded.Length)
        {
            try
            {
                this.ChangeLastByteTo(contentEncoded[index],index);
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }
            index++;
        }
    }

    private void ChangeLastByteTo(char value, int index)
    {
        if (value == '1')
        {
            this._bytesRGB[index] = (byte)(this._bytesRGB[index] & 0b0000_0001);
            return;
        }
        this._bytesRGB[index] = (byte)(this._bytesRGB[index] | 0b1111_1110);
    }

    protected override void SaveTo(string outputPath)
    {
        // Créer l'image
        using (Bitmap bitmap = new Bitmap(this._width, this._height))
        {
            int index = 0;

            for (int y = 0; y < this._height; y++)
            {
                for (int x = 0; x < this._width; x++)
                {
                    try
                    {
                        // Récupérer les valeurs R, G et B
                        byte red = this._bytesRGB[index++];
                        byte green = this._bytesRGB[index++];
                        byte blue = this._bytesRGB[index++];
                        
                        
                        // Définir le pixel
                        Color color = Color.FromArgb(red, green, blue);
                        bitmap.SetPixel(x, y, color);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        break;
                    }
                }
            }

            bitmap.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}