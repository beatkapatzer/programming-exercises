//5. Napisz rekurencyjny program generujący kolejne wyrazy ciągu Fibonacciego  
//6.Napisz iteracyjny program obliczający kolejne wyrazy ciągu Fibonacciego  
using System;
class Fibanacci
{
    static void Main()
    {
        Console.WriteLine(fib1(3));
        fib2(11);
    }
   private static int fib1(int i)
    {
        if (i <= 2)
        {
            return 1;
        }
        return fib1(i - 2) + fib1(i - 1);
       
    }
    private static void fib2(int n)
    {
        double x=0;
        double y=1;
        for (int i = 0; i < n ; i++)
        {
            y += x;
            x = y-x;
           Console.WriteLine(y);
        }
       
    }
}