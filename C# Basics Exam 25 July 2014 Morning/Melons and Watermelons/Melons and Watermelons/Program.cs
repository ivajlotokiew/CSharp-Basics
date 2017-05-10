using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Melons_and_Watermelons
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int weekStartindDay = int.Parse(Console.ReadLine());
        int numberOfDays = int.Parse(Console.ReadLine());
        int sumM = 0;
        int sumW = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            switch (weekStartindDay)
            {
                case 1: sumW += 1; break;
                case 2: sumM += 2; break;
                case 3: sumM += 1; sumW += 1; break;
                case 4: sumW += 2; break;
                case 5: sumM += 2; sumW += 2; break;
                case 6: sumM += 2; sumW += 1; break;
                case 7: break;
            }
            weekStartindDay++;
            if (weekStartindDay > 7)
            {
                weekStartindDay = 1;
            }
        }
        if (sumW > sumM)
        {
            Console.WriteLine("{0} more watermelons", sumW - sumM);
        }
        else if (sumW < sumM)
        {
            Console.WriteLine("{0} more melons", sumM - sumW);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", sumM);

        }
    }
}