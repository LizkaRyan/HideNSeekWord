using TextBuster.Coding;
using TextBuster.Coding.Tree;

namespace TextBuster.Steganography.Image;

public class KeyImageDecoder:KeyDecoder
{
    HashSet<int> _randomPlace;
    
    public HashSet<int> RandomPlace {get => _randomPlace; set => _randomPlace = value; }

    public KeyImageDecoder()
    {
        _randomPlace = new HashSet<int>();
    }

    internal void AddRandomPlace(int place)
    {
        this._randomPlace.Add(place);
    }
    
    public override KeyDecoder CreateKeyDecoder(GraphCollection graphs)
    {
        graphs.CreateTree();
        return graphs.CreateKeyDecoder(this);
    }
}