using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography.Image;

public class KeyImageDecoder:KeyDecoder
{
    private HashSet<int> _randomPlace;

    public KeyImageDecoder()
    {
        _randomPlace = new HashSet<int>();
    }
    
    public override KeyDecoder CreateKeyDecoder(GraphCollection graphs)
    {
        graphs.CreateTree();
        return graphs.CreateKeyDecoder(this);
    }
}