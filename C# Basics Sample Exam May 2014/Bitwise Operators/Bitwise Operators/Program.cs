using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class We_all_love_bits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int countNumber = int.Parse(Console.ReadLine());
        for (int j = 0; j < countNumber; j++)
        {
            int number = int.Parse(Console.ReadLine());
            int numberInvert = number;
            int numberReverse = number;
            string bitsString = Convert.ToString(number, 2);
            for (int i = 0; i < bitsString.Length; i++)
            {
                int mask = 1 << i;
                if ((numberInvert & mask) > 0)
                {
                    numberInvert &= ~mask;
                }
                else
                {
                    numberInvert |= mask;
                }
                int maskReveres = 1 << bitsString.Length - i - 1;
                if ((number & maskReveres) > 0)
                {
                    numberReverse |= 1 << i;
                }
                else
                {
                    numberReverse &= ~(1 << i);
                }
            }
            int numberNew = (number ^ numberInvert) & numberReverse;
            Console.WriteLine(numberNew);
        }
    }
}