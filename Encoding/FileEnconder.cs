using System.Text.Json;
using TextBuster.Encoding.Tree;

namespace TextBuster.Encoding;

public class FileEnconder
{
    private string _filePath;
    private Dictionary<string, string> _dico;
    private string _content;

    public FileEnconder(string filePath)
    {
        _filePath = filePath;
        _content = File.ReadAllText(this._filePath);
        TextAnalyzer textAnalyzer = new TextAnalyzer(_content);
        GraphCollection graphCollection = textAnalyzer.CreateGraphCollection();
        _dico=graphCollection.CreateDictionary();
    }

    public void Encode(string filePathEncoded)
    {
        try
        {
            string contentEncoded = EncodeContent();
            List<byte> bytes = OptimizeByContent(contentEncoded);
            // Écriture des octets dans un fichier
            File.WriteAllBytes(filePathEncoded, bytes.ToArray());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }

    private List<byte> OptimizeByContent(string contentEncoded)
    {
        List<byte> bytes = new List<byte>();

        // Ajout des bits dans un byte
        byte currentByte = 0;
        int bitCount = 0;

        foreach (char bit in contentEncoded)
        {
            // Ajoute chaque bit au byte courant
            currentByte = (byte)(currentByte << 1);  // Décale les bits à gauche pour ajouter un bit
            if (bit == '1')
                currentByte = (byte)(currentByte | 1);  // Si le bit est 1, on fait un OR binaire avec 1

            bitCount++;

            // Si on a un byte complet, on l'ajoute à la liste
            if (bitCount == 8)
            {
                bytes.Add(currentByte);
                currentByte = 0;
                bitCount = 0;
            }
        }

        // Si il reste des bits, ajouter un byte partiel
        if (bitCount > 0)
        {
            currentByte = (byte)(currentByte << (8 - bitCount));  // Décale à gauche pour compléter le byte
            bytes.Add(currentByte);
        }
        return bytes;
    }

    private string EncodeContent()
    {
        string byteString = "";
        foreach (char charachter in _content)
        {
            byteString+=this._dico[charachter.ToString()];
            
        }

        return byteString;
    }

    public void GiveKey(string filePath)
    {
        // Convertir le dictionnaire en JSON
        string json = JsonSerializer.Serialize(this._dico, new JsonSerializerOptions { WriteIndented = true });

        // Écrire le JSON dans un fichier
        File.WriteAllText(filePath, json);
    }
}