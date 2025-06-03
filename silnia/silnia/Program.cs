//4. Napisz rekurencyjną realizację obliczenia silni tworząc funkcję silnia(n);  
using System;
class Silania
{
    static void Main()
    {
        int a;
        Console.WriteLine("podaj liczbe: ");
        a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("silnia: " + Factorial(a)); 
    }
    static int Factorial( int x)
    {
        int y = 0;
        int b = 1;
        if ((x == 1 )||(x== 0))
        {
            Console.WriteLine(b);
            return 1;
        }
        else
        {
          y= Factorial(x-1)* x;
            b++;
            return y;
        }
    }
}