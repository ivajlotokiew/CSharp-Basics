using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Electricity
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numberFloors = int.Parse(Console.ReadLine());
        int numberFlats = int.Parse(Console.ReadLine());
        string timeOfTheDay = Console.ReadLine();
        string[] hoursAndMinutes = timeOfTheDay.Split(':');
        int hours = Convert.ToInt32(hoursAndMinutes[0]);
        int minutes = Convert.ToInt32(hoursAndMinutes[1]);
        int totalWats = 0;
        double wattsLamp = 100.53;
        double wattsComputer = 125.90;
        int wholeFlats = numberFlats * numberFloors;
        if ((hours >= 14 && minutes >= 0) && (hours <= 18 && minutes <= 59))
        {
            totalWats = (int)(wholeFlats * (2 * wattsLamp + 2 * wattsComputer));
            Console.WriteLine("{0} Watts", totalWats);
        }
        else if ((hours >= 19 && minutes >= 0) && (hours <= 23 && minutes <= 59))
        {
            totalWats = (int)(wholeFlats * (7 * wattsLamp + 6 * wattsComputer));
            Console.WriteLine("{0} Watts", totalWats);
        }
        else if ((hours >= 0 && minutes >= 0) && (hours <= 8 && minutes <= 59))
        {
            totalWats = (int)(wholeFlats * (wattsLamp + 8 * wattsComputer));
            Console.WriteLine("{0} Watts", totalWats);
        }
        else
        {
            Console.WriteLine("0 Watts");
        }
    }
}