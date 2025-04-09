namespace TextBuster.Steganography;

public class Random
{
    private int seed;

    public Random()
    {
        this.seed = Environment.TickCount;
    }
}