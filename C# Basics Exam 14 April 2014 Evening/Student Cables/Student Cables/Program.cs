using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class Student_Cabbles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numbOfCables = int.Parse(Console.ReadLine());
        int sumCable = 0;
        int numberStudentCables = 0;
        int looseCableConnection = 0;
        int usedCable = 0;
        for (int i = 0; i < numbOfCables; i++)
        {
            int sizeCable = int.Parse(Console.ReadLine());
            string measuredCable = Console.ReadLine();

            if (sizeCable < 20 && measuredCable == "centimeters")
            {
                continue;
            }
            else if (measuredCable == "meters")
            {
                sumCable += sizeCable * 100;
                looseCableConnection++;
            }
            else
            {
                sumCable += sizeCable;
                looseCableConnection++;
            }
        }
        numberStudentCables = (sumCable - 3 * (looseCableConnection - 1)) / 504;
        usedCable = numberStudentCables * 504;

        Console.WriteLine(numberStudentCables);
        Console.WriteLine(sumCable - 3 * (looseCableConnection - 1) - usedCable);
    }
}