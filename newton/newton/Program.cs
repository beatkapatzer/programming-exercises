//7. Napisz program obliczający wartość symbolu newtona dla zadanych parametrów n i k. 
using System;
class Newton
{
    static void Main()
    {
        Console.WriteLine(Newt(10, 8));
    }

    private static int Newt(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    static int Factorial(int x)
    {
        int y = 0;
        int b = 1;
        if ((x == 1) || (x == 0))
        {
            return 1;
        }
        else
        {
            y = Factorial(x - 1) * x;
            b++;
            return y;
        }
    }
}