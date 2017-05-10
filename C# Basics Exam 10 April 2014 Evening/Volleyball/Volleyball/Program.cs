using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

class Volleyball
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string isYearLeap = Console.ReadLine();
        double hollydayNumb = double.Parse(Console.ReadLine());
        double hometownNumb = double.Parse(Console.ReadLine());
        double normalWeek = (48 - hometownNumb) * 3 / 4;
        double hollydayPlays = hollydayNumb * 2 / 3;
        double totalPlays = hometownNumb + hollydayPlays + normalWeek;
        //   Console.WriteLine(totalPlays);
        if (isYearLeap == "leap")
        {
            Console.WriteLine("{0}", (int)(totalPlays + (totalPlays * 0.15)));
        }
        else
        {
            Console.WriteLine("{0}", (int)totalPlays);

        }
    }
}