using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Nakovs_Matching
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string wordOne = Console.ReadLine();
        string wordOneLeft = string.Empty;
        string wordOneRight = string.Empty;
        string wordTwo = Console.ReadLine();
        string wordTwoLeft = string.Empty;
        string wordTwoRight = string.Empty;
        int limitNumber = int.Parse(Console.ReadLine());
        bool isResult = false;
        int sumWordOneLeft = 0;
        int sumWordOneRight = 0;
        int sumWordTwoLeft = 0;
        int sumWordTwoRight = 0;
        int totalResult = 0;
        for (int i = 0; i < wordOne.Length - 1; i++)
        {
            wordOneLeft += wordOne[i];
            wordOneRight = wordOne.Remove(0, i + 1);
            for (int i1 = 0; i1 < wordOneLeft.Length; i1++)
            {
                sumWordOneLeft += wordOneLeft[i1];
            }
            for (int i2 = 0; i2 < wordOneRight.Length; i2++)
            {
                sumWordOneRight += wordOneRight[i2];
            }

            for (int j = 0; j < wordTwo.Length - 1; j++)
            {
                wordTwoLeft += wordTwo[j];
                wordTwoRight = wordTwo.Remove(0, j + 1);

                for (int j1 = 0; j1 < wordTwoLeft.Length; j1++)
                {
                    sumWordTwoLeft += wordTwoLeft[j1];
                }
                for (int j2 = 0; j2 < wordTwoRight.Length; j2++)
                {
                    sumWordTwoRight += wordTwoRight[j2];
                }

                totalResult = Math.Abs(sumWordOneLeft * sumWordTwoRight - sumWordOneRight * sumWordTwoLeft);
                if (totalResult <= limitNumber)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", wordOneLeft, wordOneRight, wordTwoLeft, wordTwoRight, totalResult);
                    isResult = true;
                }
                totalResult = 0;
                sumWordTwoLeft = 0;
                sumWordTwoRight = 0;
                wordTwoRight = string.Empty;
            }
            wordTwoLeft = string.Empty;
            wordTwoRight = string.Empty;
            wordOneRight = string.Empty;
            sumWordOneLeft = 0;
            sumWordOneRight = 0;

        }
        if (!isResult)
        {
            Console.WriteLine("No");
        }
    }
}