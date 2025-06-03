using System;
using System.Text;
class LiczenieZnakow
{
    static void Main()
    {
         
        string zawartosc = File.ReadAllText("C:\\Users\\beatk\\Desktop\\studia\\programowanie\\cos.txt", Encoding.UTF8);
        int[] charCounts = new int[256];

        foreach (char c in zawartosc)
        {
            charCounts[(int)c]++;
        }

        for (int i = 0; i < charCounts.Length; i++)
        {
            Console.WriteLine($"Znak: '{(char)i}', Wystąpienia: {charCounts[i]}");
        }
    }
}
