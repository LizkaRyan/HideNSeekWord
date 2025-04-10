using System.Text.Json;
using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography.Image;

public class ImageEncoder:Encoder
{

    private ByteCollection _bytesRGB;

    private int _height;
    
    private int _width;

    private string _imagePath;
    
    public ImageEncoder(string imagePath,string content)
    {
        this._imagePath = imagePath;
        this._content = content;
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
        KeyImageDecoder keyDecoder = (KeyImageDecoder)this._key;
        keyDecoder.SetRandomPlace(this._bytesRGB.Count,contentEncoded.Length);
        foreach (int place in keyDecoder.RandomPlace)
        {
            try
            {
                this.ChangeLastByteTo(contentEncoded[index],place);
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
        KeyImageDecoder keyImageDecoder = (KeyImageDecoder)this._key!;
        keyImageDecoder.AddRandomPlace(index);
        string binaryString = Convert.ToString(this._bytesRGB[index], 2).PadLeft(8, '0');
        if (value == '1')
        {
            this._bytesRGB[index] = (byte)(this._bytesRGB[index] | 1);
            binaryString = Convert.ToString(this._bytesRGB[index], 2).PadLeft(8, '0');
            return;
        }
        this._bytesRGB[index] = (byte)(this._bytesRGB[index] & ~1);
        binaryString = Convert.ToString(this._bytesRGB[index], 2).PadLeft(8, '0');
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
                        // Définir le pixel
                        Color color = Color.FromArgb( this._bytesRGB[index],this._bytesRGB[index+1],this._bytesRGB[index+2]);
                        bitmap.SetPixel(x, y, color);
                        index += 3;
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
    
    public override void GiveKey(string filePath)
    {
        // Convertir le dictionnaire en JSON
        string json = JsonSerializer.Serialize((KeyImageDecoder)this.Key, new JsonSerializerOptions { WriteIndented = true });

        // Écrire le JSON dans un fichier
        File.WriteAllText(filePath, json);
    }
}