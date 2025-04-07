namespace TextBuster.Encoding.Graph;

public class Graph
{
    private char _character;
    private int _nbAppearances;
    
    public int NbAppearances {get => _nbAppearances;}
    
    private Node? Node { get; set; }

    public Graph(char character, int nbAppearances)
    {
        _character = character;
        _nbAppearances = nbAppearances;
    }
}