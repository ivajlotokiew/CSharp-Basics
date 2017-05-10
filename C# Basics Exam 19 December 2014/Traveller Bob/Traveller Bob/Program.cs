using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Traveller_Bob
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string isLeap = Console.ReadLine();
        double contractMonths = double.Parse(Console.ReadLine());
        double famillyMonths = double.Parse(Console.ReadLine());
        double normalMonths = 12 - contractMonths - famillyMonths;
        double contractMonthsTravels = contractMonths * 12;
        double famillyMonthsTravels = famillyMonths * 4;
        double normalMonthsTravels = normalMonths * 12 * 3 / 5;
        double totalTravels = contractMonthsTravels + famillyMonthsTravels + normalMonthsTravels;
        if (isLeap == "leap")
        {
            Console.WriteLine((int)(totalTravels + ((5.00 / 100) * totalTravels)));
        }
        else
        {
            Console.WriteLine((int)(totalTravels));

        }
    }
}