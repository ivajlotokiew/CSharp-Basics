using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Weird_Combinations
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string combination = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        string resultCombination = string.Empty;
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
                            resultCombination = "" + combination[i1] + combination[i2] + combination[i3] +
                                combination[i4] + combination[i5];
                            count++;
                            if (count == number + 1)
                            {
                                Console.WriteLine(resultCombination);
                            }
                            resultCombination = string.Empty;
                        }
                    }
                }
            }
        }
        if (count < number + 1)
        {
            Console.WriteLine("No");
        }
    }
}