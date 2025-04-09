namespace TextBuster.Steganography;

public class Random
{
    // Paramètres du générateur
    private long a = 1664525;  // Multiplicateur
    private long c = 1013904223;  // Incrément
    private long m = (long) Math.Pow(2, 32);  // Module
    private long seed;  // Graine (valeur initiale)

    // Constructeur pour initialiser la graine
    public Random() {
        this.seed = Environment.TickCount;;
    }

    // Méthode pour générer un nombre pseudo-aléatoire entre min et max (inclus)
    public int NextInt(int min, int max) {
        seed = (a * seed + c) % m;  // Calcul de Xn+1
        return (int) (min + (seed % (max - min + 1)));  // Ajuste dans l'intervalle [min, max]
    }
}