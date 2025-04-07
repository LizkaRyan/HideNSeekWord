namespace TextBuster.Encoding.Tree;

public class Node
{
    String byteString;
    Graph graph;

    public Node(String byteString, Graph graph)
    {
        this.byteString = byteString;
        this.graph = graph;
    }
}