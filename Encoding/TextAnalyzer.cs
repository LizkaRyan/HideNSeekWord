using TextBuster.Encoding.Graph;

namespace TextBuster.Encoding;

public class TextAnalyzer
{
    private string _content;
    private HashSet<char> _chars;
    
    public TextAnalyzer(string textToAnalyze)
    {
        this._content = textToAnalyze;
        SetAllPossibleCharacters();
    }

    private void SetAllPossibleCharacters()
    {
        _chars = new HashSet<char>();

        foreach (char character in _content)
        {
            _chars.Add(character);
        }
    }

    public GraphCollection CreateGraphCollection()
    {
        GraphCollection graphCollection = new GraphCollection();
        foreach (char character in this._chars)
        {
            graphCollection.Add(new Graph(character,this._chars.Count(c => c==character)));
        }
        return graphCollection.Sort((a, b) => b.NbAppearances.CompareTo(a.NbAppearances));
    }
}