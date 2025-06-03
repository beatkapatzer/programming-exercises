using System;
class Palindromy
{
    static void Main()
    {
        Console.WriteLine("Podaj 1 zdanie");
        string zdanie1 = Console.ReadLine();
        Console.WriteLine("Podaj 2 zdanie");
        string zdanie2 = Console.ReadLine();
        Console.WriteLine(Palindrom(zdanie1));
        Console.WriteLine(Palindrom(zdanie2));

    }
    static bool Palindrom(string zdanie)
    {
        zdanie = zdanie.Replace(" ", "").ToLower();
        int lewo = 0;
        int prawo = zdanie.Length - 1;
        while (lewo < prawo)
        {
            if (zdanie[lewo] != zdanie[prawo])
            {
                return false;
            }
            lewo++;
            prawo--;
        }
        return true;
    }
}