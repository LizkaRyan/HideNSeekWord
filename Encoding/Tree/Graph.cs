namespace TextBuster.Encoding.Tree;

public class Graph
{
    private string _character;
    private int _nbAppearances;
    private Node[] _node;
    
    public string Character { get => _character; }
    
    public int NbAppearances {get => _nbAppearances;}

    public Graph(string character, int nbAppearances)
    {
        _character = character;
        _nbAppearances = nbAppearances;
        _node = new Node[2];
    }

    public void AddChildren(Graph graph1,Graph graph2)
    {
        this._node[0]=new Node("0",graph1);
        this._node[1]=new Node("1",graph2);
    }
}