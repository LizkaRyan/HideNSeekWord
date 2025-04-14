namespace TextBuster.Coding.Tree;

public class Graph
{
    private string _character;
    private int _nbAppearances;
    private string _byteString;
    private Graph[] _graphs;
    
    public string ByteString {get => _byteString;}

    public string Character
    {
        get => _character;
    }

    public int NbAppearances
    {
        get => _nbAppearances;
    }

    public Graph(string character, int nbAppearances)
    {
        _character = character;
        _nbAppearances = nbAppearances;
        _graphs = new Graph[2];
        _byteString = "";
    }

    public Graph(string character, int nbAppearances, string byteStringString)
    {
        _character = character;
        _nbAppearances = nbAppearances;
        _graphs = new Graph[2];
        _byteString = byteStringString;
    }

    public void AddChildren(Graph graph1, Graph graph2)
    {
        this._graphs[0] = graph1;
        this._graphs[0]._byteString = this.ByteString+"0";
        this._graphs[1] = graph2;
        this._graphs[1]._byteString = this.ByteString+"1";
    }

    public string GetGraphByCharacter(string character)
    {
        if (this._character == character)
        {
            return this._byteString;
        }

        if (this._graphs[0]._character.Contains(character))
        {
            return this._byteString+this._graphs[0].GetGraphByCharacter(character);
        }

        return this._byteString+this._graphs[1].GetGraphByCharacter(character);
    }
}