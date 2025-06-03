//2. Napisz program konwertujący z kodu NKB do dziesiętnego  
using System;
class Nkb
    {
        static void Main()
        {
            string no = "1010";
            string[] numberArray = new string[no.Length];
            int counter = 0;

            for (int i = 0; i < no.Length; i++)
            {
                numberArray[i] = no.Substring(counter, 1);
                counter++;
            }

            int currentNumber;
            int result = 0;
            int power = 0;

            for (int i = numberArray.Length - 1; i >= 0; i--)
            {
                currentNumber = Convert.ToInt32(numberArray[i]);
                result += Convert.ToInt32(currentNumber * Math.Pow(2, power));
                power++;
            }
            Console.WriteLine(result);
        }
    }

    
