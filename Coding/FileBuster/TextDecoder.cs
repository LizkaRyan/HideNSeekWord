using System.Text.Json;
using TextBuster.Steganography;

namespace TextBuster.Coding.FileBuster;

public class TextDecoder:Decoder
{
    
    protected ByteCollection _bytes;

    public TextDecoder(string filePath, string fileKey) : base(filePath, fileKey)
    {
        _bytes = new ByteCollection(filePath);
    }
    
    protected override void Decode()
    {
        KeyDecoder keyDecoder = Key.Invert();
        string bytesString = _bytes.ToString();
        while (bytesString.Length > 0)
        {
            for (int i = Math.Min(keyDecoder.MaxLengthByte, bytesString.Length); i > 0; i--)
            {
                string byteTest = bytesString.Substring(0, i);
                if (keyDecoder.ContainsKey(byteTest))
                {
                    this._content += keyDecoder[byteTest];
                    bytesString = bytesString.Substring(i, bytesString.Length - i);
                    break;
                }
            }
        }
    }
}