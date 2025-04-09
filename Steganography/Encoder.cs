using System.Text.Json;
using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography;

public abstract class Encoder
{
    protected string _content;
    
    protected KeyDecoder? _key;

    public KeyDecoder Key {get => _key ?? throw new InvalidOperationException(); }
    
    public string Content
    {
        get => _content;
    }
    
    protected string BinarizeContent()
    {
        string byteString = "";
        foreach (char charachter in Content)
        {
            byteString+=this.Key![charachter.ToString()];
        }

        return byteString;
    }

    public Encoder(string filePath)
    {
        _content = File.ReadAllText(filePath);
    }
    
    public void GiveKey(string filePath)
    {
        // Convertir le dictionnaire en JSON
        string json = JsonSerializer.Serialize(this.Key, new JsonSerializerOptions { WriteIndented = true });

        // Écrire le JSON dans un fichier
        File.WriteAllText(filePath, json);
    }
    
    protected abstract void Encode();

    protected abstract void SaveTo(string outputPath);

    public void EncodeAndSaveTo(string outPutPathEncoded)
    {
        Encode();
        SaveTo(outPutPathEncoded);
    }
}