using System.Text.Json;
using TextBuster.Coding;

namespace TextBuster.Steganography;

public abstract class Decoder
{
    
    protected string _content;
    
    protected KeyDecoder? _key;

    protected string _filePath;
    
    public KeyDecoder Key {get => _key ?? throw new InvalidOperationException(); set => _key = value; }

    public Decoder(string filePath)
    {
        this._filePath = filePath;
        this._content = "";
    }
    
    protected abstract void Decode();

    protected void SaveTo(string outputPath)
    {
        File.WriteAllText(outputPath, this._content);
    }

    public void DecodeAndSaveTo(string outPutPathEncoded)
    {
        Decode();
        SaveTo(outPutPathEncoded);
    }
}