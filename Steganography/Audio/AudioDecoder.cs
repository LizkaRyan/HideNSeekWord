using System.Text.Json;
using TextBuster.Coding;
using TextBuster.Steganography.Image;

namespace TextBuster.Steganography.Audio;

public class AudioDecoder:Decoder
{
    ByteCollection _bytes;
    
    public AudioDecoder(string filePath,string fileKey) : base(filePath)
    {
        string jsonKey=File.ReadAllText(fileKey);
        KeyAudioDecoder keyImageDecoder = JsonSerializer.Deserialize<KeyAudioDecoder>(jsonKey);
        this._key = keyImageDecoder;
    }
    
    public string GetContentByte()
    {
        KeyAudioDecoder keyDecoder = (KeyAudioDecoder)this._key;
        string content = "";
        foreach (int randomPlace in keyDecoder.RandomPlace)
        {
            content += (this._bytes[randomPlace] & 1) == 1 ? "1" : "0";
        }
        return content;
    }

    protected override void Decode()
    {
        this._bytes = new ByteCollection(File.ReadAllBytes(this._filePath));
        KeyDecoder keyDecoder = Key.Invert();
        string bytesString = GetContentByte();
        keyDecoder.Decode(bytesString);
        this._content = keyDecoder.Content;
    }
}