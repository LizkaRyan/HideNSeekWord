using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography.Image;

public class ImageDecoder:Decoder
{
    private int _width;
    
    private int _height;
    
    private ByteCollection _bytesRGB;

    public ImageDecoder(string filePath, string fileKey):base(filePath,fileKey)
    {
        this.SetRGB();
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
        this._content = this._key.Decode(this._bytesRGB);
    }
}