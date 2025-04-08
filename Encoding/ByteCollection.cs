using System.Text;

namespace TextBuster.Encoding;

public class ByteCollection:List<Byte>
{

    private int _unusedBytes;

    public int UnusedBytes
    {
        get { return _unusedBytes; }
    }

    public ByteCollection(byte[] bytes)
    {
        this._unusedBytes = bytes[0];
        this.AddRange(bytes.Skip(1));
    }
    
    public ByteCollection(string contentEncoded)
    {
        _unusedBytes = 0;
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
                this.Add(currentByte);
                currentByte = 0;
                bitCount = 0;
            }
        }

        // Si il reste des bits, ajouter un byte partiel
        if (bitCount > 0)
        {
            _unusedBytes = 8 - bitCount;
            currentByte = (byte)(currentByte << (8 - bitCount));  // Décale à gauche pour compléter le byte
            this.Add(currentByte);
        }
    }

    public override string ToString()
    {
        StringBuilder binaryStringBuilder = new StringBuilder();
        foreach (byte b in this)
        {
            // Convertir chaque byte en une chaîne binaire de 8 bits
            binaryStringBuilder.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
        }
        string binaryString = binaryStringBuilder.ToString();
        return binaryString.Substring(0,binaryString.Length - _unusedBytes);
    }
}