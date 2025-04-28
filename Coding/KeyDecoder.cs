using System.Text.Json;
using TextBuster.Coding.Tree;
using Random = TextBuster.Steganography.Random;

namespace TextBuster.Coding;

public class KeyDecoder
{
    private Dictionary<string, string> _dico = new();
    
    private int _maxLengthByte;

    private string _content;

    private int _lengthMessage;
    
    public int LengthMessage
    {
        get { return _lengthMessage; }
        set { _lengthMessage = value; }
    }

    public string Content => _content;

    public Random _random;
    
    public Random Random => _random;
    
    public Dictionary<string,string> Dico {get => _dico; set => _dico = value; }
    
    public int MaxLengthByte
    {
        get => _maxLengthByte;
    }

    public KeyDecoder()
    {
        _maxLengthByte = 0;
        _random = new Random(5);
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

    public void Decode(string bytesString)
    {
        while (bytesString.Length > 0)
        {
            for (int i = Math.Min(this.MaxLengthByte, bytesString.Length); i > 0; i--)
            {
                string byteTest = bytesString.Substring(0, i);
                if (this.Dico.ContainsKey(byteTest))
                {
                    this._content += this.Dico[byteTest];
                    bytesString = bytesString.Substring(i, bytesString.Length - i);
                    break;
                }
            }
        }
    }
    
    public bool IsALanguage()
    {
        LanguageAnalyzer languageAnalyzer = new LanguageAnalyzer(this._dico);
        return languageAnalyzer.IsALanguage();
    }
}