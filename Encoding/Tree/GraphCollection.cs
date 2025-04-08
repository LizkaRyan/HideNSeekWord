namespace TextBuster.Encoding.Tree;

public class GraphCollection:List<Graph>
{

    private HashSet<char> _characters = new HashSet<char>();
    
    public HashSet<char> Characters { get => _characters; set => _characters = value; }
    
    private void AssembleSmallestGraphFrequence()
    {
        if (this.Count == 1)
        {
            return;
        }
        Graph graph = new Graph(this[0].Character+this[1].Character, this[0].NbAppearances+this[1].NbAppearances);
        graph.AddChildren(this[0],this[1]);
        this.RemoveAt(0);
        this.RemoveAt(0);
        this.Add(graph);
    }
    
    private void CreateTree()
    {
        while (this.Count > 1)
        {
            Sort((a, b) => a.NbAppearances.CompareTo(b.NbAppearances));
            AssembleSmallestGraphFrequence();
        }
    }

    public KeyDecoder CreateDictionary()
    {
        this.CreateTree();
        KeyDecoder dictionary = new KeyDecoder();
        foreach (char character in _characters)
        {
            dictionary.Add(character.ToString(), this[0].GetGraphByCharacter(character.ToString()));
        }
        return dictionary;
    }
}