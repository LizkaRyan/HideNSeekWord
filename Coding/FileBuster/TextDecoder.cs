using System.Text.Json;
using TextBuster.Steganography;

namespace TextBuster.Coding.FileBuster;

public class TextDecoder:Decoder
{
    
    protected ByteCollection _bytes;

    public TextDecoder(string filePath, string fileKey) : base(filePath)
    {
        _bytes = new ByteCollection(filePath);
        string jsonKey=File.ReadAllText(fileKey);
        this._key = JsonSerializer.Deserialize<KeyDecoder>(jsonKey);
    }
    
    protected override void Decode()
    {
        KeyDecoder keyDecoder = Key.Invert();
        string bytesString = _bytes.ToString();
        keyDecoder.Decode(bytesString);
        this._content = keyDecoder.Content;
    }
}