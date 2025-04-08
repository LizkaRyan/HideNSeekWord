namespace TextBuster.Encoding.FileBuster;

public class FileBuster(string filePath)
{
    protected KeyDecoder? Key;
    protected readonly string filePath = filePath;
    protected readonly string Content = File.ReadAllText(filePath);
}