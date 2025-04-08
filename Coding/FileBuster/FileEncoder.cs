using System.Text.Json;
using TextBuster.Coding.Tree;

namespace TextBuster.Coding.FileBuster;

public class FileEncoder:FileBuster
{
    public FileEncoder(string filePath):base(filePath)
    {
        TextAnalyzer textAnalyzer = new TextAnalyzer(Content);
        GraphCollection graphCollection = textAnalyzer.CreateGraphCollection();
        Key=graphCollection.CreateDictionary();
    }

    public void EncodeAndSaveTo(string filePathEncoded)
    {
        string contentEncoded = EncodeContent();
        ByteCollection bytes = new ByteCollection(contentEncoded);
        
        // Écrire dans le fichier
        using (FileStream fs = new FileStream(filePathEncoded, FileMode.Create))
        {
            // En-tête : premier octet (nombre de bits inutilisés)
            fs.WriteByte((byte)bytes.UnusedBytes);
            Console.WriteLine(bytes.UnusedBytes+" UnusedBytes");
            // Écrire les données encodées (les bytes)
            fs.Write(bytes.ToArray(), 0, bytes.Count);
        }
    }

    private string EncodeContent()
    {
        string byteString = "";
        foreach (char charachter in Content)
        {
            byteString+=this.Key[charachter.ToString()];
        }

        return byteString;
    }

    public void GiveKey(string filePath)
    {
        // Convertir le dictionnaire en JSON
        string json = JsonSerializer.Serialize(this.Key, new JsonSerializerOptions { WriteIndented = true });

        // Écrire le JSON dans un fichier
        File.WriteAllText(filePath, json);
    }
}