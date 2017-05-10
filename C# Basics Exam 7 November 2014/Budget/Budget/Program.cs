using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Budget
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int amountMonthMoney = int.Parse(Console.ReadLine());
        int weekDaysGoesOut = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        int normalWeekends = 4 - hometownWeekends;
        int normalWeekDays = 22 - weekDaysGoesOut;
        int totalSum = normalWeekDays * 10 + weekDaysGoesOut * (3 * amountMonthMoney / 100 + 10) + normalWeekends * 40 + 150;
        if (amountMonthMoney > totalSum)
        {
            Console.WriteLine("Yes, leftover {0}.", amountMonthMoney - totalSum);
        }
        else if (amountMonthMoney < totalSum)
        {
            Console.WriteLine("No, not enough {0}.", Math.Abs(amountMonthMoney - totalSum));
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}