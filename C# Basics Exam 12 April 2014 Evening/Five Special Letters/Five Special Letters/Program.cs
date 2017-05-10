using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Five_Special_Letters
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        char[] sequance = { 'a', 'b', 'c', 'd', 'e' };
        bool isResult = false;
        string currentSequence = string.Empty;

        for (int i1 = 0; i1 < 5; i1++)
        {
            for (int i2 = 0; i2 < 5; i2++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    for (int i4 = 0; i4 < 5; i4++)
                    {
                        for (int i5 = 0; i5 < 5; i5++)
                        {
                            currentSequence = "" + sequance[i1] + sequance[i2] + sequance[i3]
                                + sequance[i4] + sequance[i5];
                            if (CalcWeight(currentSequence) >= start && CalcWeight(currentSequence) <= end)
                            {
                                Console.Write(currentSequence + " ");
                                isResult = true;
                            }
                        }
                    }
                }
            }
        }
        if (!isResult)
        {
            Console.WriteLine("No");
        }
    }
    static long CalcWeight(string word)
    {
        char[] matrix = new char[5];
        int k = 0;
        int br = 1;
        long totalSum = 0;
        foreach (var item in word)
        {
            matrix[k] = item;
            k++;
        }
        var result = matrix.Distinct();
        foreach (var item in result)
        {
            switch (item)
            {
                case 'a': totalSum += 5 * br; break;
                case 'b': totalSum += -12 * br; break;
                case 'c': totalSum += 47 * br; break;
                case 'd': totalSum += 7 * br; break;
                case 'e': totalSum += -32 * br; break;

            }
            br++;
        }
        return totalSum;
    }
}