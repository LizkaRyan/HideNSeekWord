namespace TextBuster.Steganography;

public class Random
{
    // Paramètres du générateur
    private readonly long _a = 2;  // Multiplicateur
    private const long C = 2459; // Incrément
    private long _xn;  // Initial value
    private long _initValue;
    private long m = 5;
    
    public long InitValue { get => _initValue; set => _initValue = value; }

    // Constructeur pour initialiser la graine
    public Random(int xn)
    {
        this._xn = xn;
        this._initValue = xn;
    }

    // Méthode pour générer un nombre pseudo-aléatoire entre min et max (inclus)
    public int NextInt() {
        _xn = (_a * _xn + C) % m;  // Calcul de Xn+1
        if (_xn == 0)
        {
            _xn = 1;
        }
        return (int)_xn;  // Ajuste dans l'intervalle [min, max]
    }
}