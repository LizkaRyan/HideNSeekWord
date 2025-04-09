using System.Text.Json;
using TextBuster.Steganography;

namespace TextBuster.Coding.FileBuster;

public class TextDecoder(string _filePath, string fileKey) : Decoder(_filePath, fileKey)
{

    protected override void Decode()
    {
        ByteCollection bytes = new ByteCollection(File.ReadAllBytes(this._filePath));
        KeyDecoder keyDecoder = Key.Invert();
        string bytesString = bytes.ToString();
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