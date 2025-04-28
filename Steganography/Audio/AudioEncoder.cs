using System.Text.Json;
using NAudio.Wave;
using TextBuster.Coding;
using TextBuster.Coding.Tree;
using TextBuster.Steganography.Image;

namespace TextBuster.Steganography.Audio;

public class AudioEncoder:Encoder
{
    private string _filePath;
    
    private ByteCollection _bytes;

    public AudioEncoder(string filePath,string content)
    {
        this._filePath = filePath;
        this._content = content;
        
        TextAnalyzer textAnalyzer = new TextAnalyzer(_content);
        GraphCollection graphCollection = textAnalyzer.CreateGraphCollection();
        _key = new KeyAudioDecoder().CreateKeyDecoder(graphCollection);
    }
    
    protected override void Encode()
    {
        string contentEncoded = BinarizeContent();
        this._bytes = new ByteCollection(File.ReadAllBytes(this._filePath));

        KeyAudioDecoder keyDecoder = (KeyAudioDecoder)this._key;
        int place = FindDataChunkStart() + (int)keyDecoder.Random.InitValue;
        for (int i=0;i<contentEncoded.Length;i++)
        {
            try
            {
                ChangeLastByteTo(contentEncoded[i],place);
                place += keyDecoder.Random.NextInt();
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }
        }
    }

    private void ChangeLastByteTo(char value, int index)
    {
        KeyAudioDecoder keyAudioDecoder = (KeyAudioDecoder)this._key!;
        if (value == '1')
        {
            this._bytes[index] = (byte)(this._bytes[index] | 1);
            return;
        }
        this._bytes[index] = (byte)(this._bytes[index] & ~1);
    }

    protected override void SaveTo(string outputPath)
    {
        // Écrire les octets dans un fichier
        File.WriteAllBytes(outputPath, this._bytes.ToArray());
    }
    
    public override void GiveKey(string filePath)
    {
        // Convertir le dictionnaire en JSON
        string json = JsonSerializer.Serialize((KeyAudioDecoder)this.Key, new JsonSerializerOptions { WriteIndented = true });

        // Écrire le JSON dans un fichier
        File.WriteAllText(filePath, json);
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
}