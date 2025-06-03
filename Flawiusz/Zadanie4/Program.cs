using System;

class Flawiusz
{
    static void Main(string[] args)
    {
        List<string> imiona = new List<string> { "Adam", "Barbara", "Cezary", "Dariusz", "Ewelina", "Franciszka" };
        int liczenie = 3;

        string ostatnia_osoba = Juliusz(imiona, liczenie, 0);
        Console.WriteLine(ostatnia_osoba);
    }

    static string Juliusz(List<string> imiona_p, int odl, int start)
    {
        if (imiona_p.Count == 1)
        {
            return imiona_p[0];
        }

        int wyeliminowany = (start + odl) % imiona_p.Count;
        for (int i = 0; i < imiona_p.Count; i++)
        {
            Console.Write(imiona_p[i] + " ");
        }
        Console.WriteLine(" ");
        imiona_p.RemoveAt(wyeliminowany);

        return Juliusz(imiona_p, odl, wyeliminowany);
    }
}