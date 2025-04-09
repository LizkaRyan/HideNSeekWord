using System.Text.Json;
using TextBuster.Coding.Tree;

namespace TextBuster.Coding;

public class KeyDecoder:Dictionary<string,string>
{
    private int _maxLengthByte;

    public int MaxLengthByte
    {
        get => _maxLengthByte;
    }

    public KeyDecoder()
    {
        _maxLengthByte = 0;
    }

    public KeyDecoder(Dictionary<string, string> dictionary) : base(dictionary)
    {
        // Initialise le champ _maxLengthByte avec la longueur maximale des valeurs
        _maxLengthByte = dictionary.Values.Any() ? dictionary.Keys.Max(v => v.Length) : 0;
    }

    public void Add(string key, string value)
    {
        base.Add(key, value);
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
        return new KeyDecoder(this.ToDictionary(key => key.Value,key => key.Key)); 
    }
}