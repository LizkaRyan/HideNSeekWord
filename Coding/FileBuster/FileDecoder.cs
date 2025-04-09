using System.Text.Json;

namespace TextBuster.Coding.FileBuster;

<<<<<<< Updated upstream:Coding/FileBuster/FileDecoder.cs
public class FileDecoder:FileBuster
{
    public FileDecoder(string filePath,string fileKey) : base(filePath)
    {
        string jsonKey=File.ReadAllText(fileKey);
        this.Key = JsonSerializer.Deserialize<KeyDecoder>(jsonKey);
    }
=======
public class TextDecoder(string _filePath, string fileKey) : Decoder(_filePath, fileKey)
{
>>>>>>> Stashed changes:Steganography/Text/TextDecoder.cs

    protected override void Decode()
    {
        ByteCollection bytes = new ByteCollection(File.ReadAllBytes(this.filePath));
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