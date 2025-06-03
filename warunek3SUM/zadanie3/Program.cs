using System;

class Warunek3SUM
{
    static void Main(string[] args)
    {
        int[] tab = { -3, 1, 2, 5, 4, 6 };

        if (!Sum(tab))
        {
            Console.WriteLine("Tablica nie zawiera liczb spełniających warunek 3SUM.");
        }
    }
    static bool Sum(int[] tab)
    {
        Array.Sort(tab);

        for (int i = 0; i < tab.Length - 2; i++)
        {
            int left = i + 1;
            int right = tab.Length - 1;

            while (left < right)
            {
                int sum = tab[i] + tab[left] + tab[right];

                if (sum == 0)
                {
                    Console.WriteLine($"Znaleziono warunek 3SUM: {tab[i]}, {tab[left]}, {tab[right]}");
                    return true;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return false;
    }
}