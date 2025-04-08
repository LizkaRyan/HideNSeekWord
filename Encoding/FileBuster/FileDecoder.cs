using System.Text.Json;

namespace TextBuster.Encoding.FileBuster;

public class FileDecoder:FileBuster
{
    public FileDecoder(string filePath,string fileKey) : base(filePath)
    {
        string jsonKey=File.ReadAllText(fileKey);
        this.Key = JsonSerializer.Deserialize<KeyDecoder>(jsonKey);
    }

    public void DecodeAndSaveTo(string filePath)
    {
        ByteCollection bytes = new ByteCollection(File.ReadAllBytes(this.filePath));
        KeyDecoder keyDecoder = Key.Invert();
        string bytesString = bytes.ToString();
        string contentDecoded = "";
        while (bytesString.Length > 0)
        {
            for (int i = Math.Min(keyDecoder.MaxLengthByte, bytesString.Length); i > 0; i--)
            {
                string byteTest = bytesString.Substring(0, i);
                if (keyDecoder.ContainsKey(byteTest))
                {
                    contentDecoded += keyDecoder[byteTest];
                    bytesString = bytesString.Substring(i, bytesString.Length - i);
                    break;
                }
            }
        }
        File.WriteAllText(filePath, contentDecoded);
    }
}