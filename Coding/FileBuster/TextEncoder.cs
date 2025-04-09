using System.Text.Json;
using TextBuster.Coding.Tree;
using TextBuster.Steganography;
using FileStream = System.IO.FileStream;

namespace TextBuster.Coding.FileBuster;

public class TextEncoder:Encoder
{
    ByteCollection bytes;
    
    public TextEncoder(string filePath):base(filePath)
    {
        TextAnalyzer analyzer = new TextAnalyzer(this._content);
        GraphCollection graphs = analyzer.CreateGraphCollection();
        this._key = new KeyDecoder().CreateKeyDecoder(graphs);
    }

    protected override void SaveTo(string outputPath)
    {
        // Écrire dans le fichier
        using (FileStream fs = new FileStream(outputPath, FileMode.Create))
        {
            // En-tête : premier octet (nombre de bits inutilisés)
            fs.WriteByte((byte)bytes.UnusedBytes);
            // Écrire les données encodées (les bytes)
            fs.Write(bytes.ToArray(), 0, bytes.Count);
        }
    }

    public void GiveKey(string filePath)
    {
        // Convertir le dictionnaire en JSON
        string json = JsonSerializer.Serialize(this.Key, new JsonSerializerOptions { WriteIndented = true });

        // Écrire le JSON dans un fichier
        File.WriteAllText(filePath, json);
    }

    protected override void Encode()
    {
        this._content = BinarizeContent();
        this.bytes = new ByteCollection(this._content);
    }
}