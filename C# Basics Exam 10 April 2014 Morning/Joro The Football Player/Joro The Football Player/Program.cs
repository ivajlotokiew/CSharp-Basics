using System;
using System.Threading;
using System.Globalization;

class JoroTheFootballPlayer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string isYearLeap = Console.ReadLine();
        double numberOfHollidays = double.Parse(Console.ReadLine());
        double numberOfHomeWeekends = double.Parse(Console.ReadLine());
        double normalWeekends = 52 - numberOfHomeWeekends;
        double playsNormalWeekends = normalWeekends * 2 / 3;
        double playsHollidays = numberOfHollidays * 0.5;
        int totalPlays = (int)(playsHollidays + playsNormalWeekends + numberOfHomeWeekends);
        if (isYearLeap == "t")
        {
            Console.WriteLine(totalPlays + 3);
        }
        else if (isYearLeap == "f")
        {
            Console.WriteLine(totalPlays);
        }
    }
}