public class Beregning
{
    static void Main(string[] args)
    {

    }

    // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
    public double SkatVedJulegave(double julegave, double andenGave)
    {


        double totalPris = julegave + andenGave;

        if (totalPris == 1200)
        {
            return 0;
        }
        else if (julegave == 900 || andenGave == 900)
        {
            return totalPris - 900;
        }


        return totalPris;
    }
}