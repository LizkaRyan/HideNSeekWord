using System.Text.Json;
using TextBuster.Coding.Tree;

namespace TextBuster.Coding;

public class KeyDecoder
{
    private Dictionary<string, string> _dico = new();
    
    private int _maxLengthByte;
    
    private string _content;
    
    public Dictionary<string,string> Dico {get => _dico;}
    
    public string Content {get => _content;}

    public int MaxLengthByte
    {
        get => _maxLengthByte;
    }

    public KeyDecoder()
    {
        _maxLengthByte = 0;
    }

    public KeyDecoder(Dictionary<string, string> dictionary)
    {
        this._dico = dictionary;
        // Initialise le champ _maxLengthByte avec la longueur maximale des valeurs
        _maxLengthByte = dictionary.Values.Any() ? dictionary.Keys.Max(v => v.Length) : 0;
    }

    public void Add(string key, string value)
    {
        this._dico.Add(key, value);
        if (value.Length > _maxLengthByte)
        {
            _maxLengthByte = value.Length;
        }
    }
    
    public virtual KeyDecoder CreateKeyDecoder(GraphCollection graphs)
    {
        graphs.CreateTree();
        return graphs.CreateKeyDecoder(this);
    }
        
    
    public KeyDecoder Invert()
    {
        return new KeyDecoder(this._dico.ToDictionary(key => key.Value,key => key.Key)); 
    }
    
    public void Decode(ByteCollection bytes)
    {
        KeyDecoder keyDecoder = this.Invert();
        string bytesString = bytes.ToString();
        string content = "";
        while (bytesString.Length > 0)
        {
            for (int i = Math.Min(keyDecoder.MaxLengthByte, bytesString.Length); i > 0; i--)
            {
                string byteTest = bytesString.Substring(0, i);
                if (keyDecoder._dico.ContainsKey(byteTest))
                {
                    content += keyDecoder._dico[byteTest];
                    bytesString = bytesString.Substring(i, bytesString.Length - i);
                    break;
                }
            }
        }

        this._content = content;
    }
}