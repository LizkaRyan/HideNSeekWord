using System.Text.Json;
using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography.Image;

public class ImageDecoder:Decoder
{
    private int _width;
    
    private int _height;
    
    private ByteCollection _bytesRGB;

    public ImageDecoder(string filePath, string fileKey):base(filePath)
    {
        this.SetRGB();
        string jsonKey=File.ReadAllText(fileKey);
        KeyImageDecoder keyImageDecoder = JsonSerializer.Deserialize<KeyImageDecoder>(jsonKey);
        this._key = keyImageDecoder;
    }
    
    
    private void SetRGB()
    {
        Bitmap image = new Bitmap(this._filePath);

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
    
    protected override void Decode()
    {
        KeyDecoder keyDecoder = Key.Invert();
        string bytesString = GetContentByte();
        keyDecoder.Decode(bytesString);
        this._content = keyDecoder.Content;
    }

    public string GetContentByte()
    {
        KeyImageDecoder keyDecoder = (KeyImageDecoder)this._key;
        string content = "";
        int place = (int)this._key.Random.InitValue;
        for (int i = 0;i<this._key.LengthMessage;i++)
        {
            content += (this._bytesRGB[(place*3)+1] & 1) == 1 ? "1" : "0";
            place += this._key.Random.NextInt();
        }
        return content;
    }
}