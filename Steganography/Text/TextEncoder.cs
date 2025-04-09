using System.Text.Json;
using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography.Text;

public class TextEncoder:Encoder
{

    private ByteCollection _bytes;
    public TextEncoder(string content):base(content)
    {
        TextAnalyzer textAnalyzer = new TextAnalyzer(_content);
        GraphCollection graphCollection = textAnalyzer.CreateGraphCollection();
        _key = new KeyDecoder().CreateKeyDecoder(graphCollection);
    }

    protected override void Encode()
    {
        string contentEncoded = BinarizeContent();
        _bytes = new ByteCollection(contentEncoded);
    }

    protected override void SaveTo(string outputPath)
    {
        // Écrire dans le fichier
        using (FileStream fs = new FileStream(outputPath, FileMode.Create))
        {
            // En-tête : premier octet (nombre de bits inutilisés)
            fs.WriteByte((byte)_bytes.UnusedBytes);
            // Écrire les données encodées (les bytes)
            fs.Write(_bytes.ToArray(), 0, _bytes.Count);
        }
    }
}