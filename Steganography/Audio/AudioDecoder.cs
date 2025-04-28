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
        int place = FindDataChunkStart()+(int)keyDecoder.Random.InitValue;
        for(int i = 0;i < this._key.LengthMessage;i++)
        {
            content += (this._bytes[place] & 1) == 1 ? "1" : "0";
            place += this._key.Random.NextInt();
        }
        return content;
    }
    
    private int FindDataChunkStart()
    {
        for (int i = 12; i < _bytes.Count - 8; i++)
        {
            // Rechercher "data" (0x64 0x61 0x74 0x61 en ASCII)
            if (_bytes[i] == 0x64 && _bytes[i + 1] == 0x61 &&
                _bytes[i + 2] == 0x74 && _bytes[i + 3] == 0x61)
            {
                return i + 8; // Les données commencent après l'identifiant "data" (4 octets) et la taille (4 octets)
            }
        }
        return -1; // Chunk "data" non trouvé
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