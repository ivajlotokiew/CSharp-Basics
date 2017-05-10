using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class OddEvenSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int number = int.Parse(Console.ReadLine());
        int[] numbMatrix = new int[2 * number];
        bool isOdd = true;
        int totalOddSum = 0;
        int totalEvenSum = 0;

        for (int i = 0; i < numbMatrix.Length; i++)
        {
            numbMatrix[i] = int.Parse(Console.ReadLine());
            if (isOdd)
            {
                totalOddSum += numbMatrix[i];
                isOdd = false;
            }
            else
            {
                totalEvenSum += numbMatrix[i];
                isOdd = true;
            }
        }
        if (totalOddSum == totalEvenSum)
        {
            Console.WriteLine("Yes, sum={0}", totalOddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(totalOddSum - totalEvenSum));
        }
    }
}