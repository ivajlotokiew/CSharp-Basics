using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

class Work_Hours
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int requiredHours = int.Parse(Console.ReadLine());
        int availableDays = int.Parse(Console.ReadLine());
        double productivityPercent = double.Parse(Console.ReadLine());
        double realWorkDays = (availableDays - ((10.00 / 100) * availableDays));
        int efficientWork = (int)(realWorkDays * 12 - (((100 - productivityPercent) / 100) * (realWorkDays * 12)));
        int difference = efficientWork - requiredHours;

        if (difference >= 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(difference);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(difference);
        }

    }
}