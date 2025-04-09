using TextBuster.Coding;
using TextBuster.Coding.Tree;
using TextBuster.Steganography.Text;

namespace TextBuster.Steganography.Image;

public class ImageEncoder:Encoder
{

    private BytesRGB _bytesRGB;

    private int _height;
    
    private int _width;

    private string _imagePath;
    
    public ImageEncoder(string imagePath,string content):base(content)
    {
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
        byte[] blues = new byte[image.Width * image.Height];
        byte[] reds = new byte[image.Width * image.Height];
        byte[] greens = new byte[image.Width * image.Height];
        int index = 0;

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixelColor = image.GetPixel(x, y);

                reds[index] = pixelColor.R;
                greens[index] = pixelColor.G;
                blues[index] = pixelColor.B;
                index++;
            }
        }
        
        this._bytesRGB = new BytesRGB(reds, greens, blues);
    }

    protected override void Encode()
    {        
        string contentEncoded = BinarizeContent();

        int index = 0;
        for (int i = 0; i < contentEncoded.Length; i+=3)
        {
            try
            {
                this._bytesRGB.ChangeLastByteRedTo(contentEncoded[i], index);
                this._bytesRGB.ChangeLastByteGreenTo(contentEncoded[i + 1], index);
                this._bytesRGB.ChangeLastByteBlueTo(contentEncoded[i + 2], index);
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }
            index++;
        }
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
                    // Récupérer les valeurs R, G et B
                    byte red = this._bytesRGB.Reds[index];
                    byte green = this._bytesRGB.Greens[index];
                    byte blue = this._bytesRGB.Blues[index];

                    index++;
                    // Définir le pixel
                    Color color = Color.FromArgb(red, green, blue);
                    bitmap.SetPixel(x, y, color);
                }
            }

            bitmap.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}