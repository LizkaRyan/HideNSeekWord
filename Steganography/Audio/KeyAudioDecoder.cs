using TextBuster.Coding;

namespace TextBuster.Steganography.Audio;

public class KeyAudioDecoder:KeyDecoder
{
    HashSet<int> _randomPlace = new HashSet<int>();

    public HashSet<int> RandomPlace {get => _randomPlace; set => _randomPlace = value; }

    public void SetRandomPlace(int minRandom,int maxRandom,int length)
    {
        Random random = new Random();
        while (_randomPlace.Count < length)
        {
            _randomPlace.Add(random.NextInt(minRandom,maxRandom));
        }
    }
}