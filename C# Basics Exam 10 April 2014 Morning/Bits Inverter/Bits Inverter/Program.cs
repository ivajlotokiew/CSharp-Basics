using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Bits_Inverter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int number = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int invertBits = 0;
        string bitsString = string.Empty;

        for (int i = 0; i < number; i++)
        {
            int bitNumber = int.Parse(Console.ReadLine());
            bitsString += Convert.ToString(bitNumber, 2).PadLeft(8, '0');
        }
        //    Console.WriteLine(bitsString);
        for (int i = 0; i < ((8 * number - 1) / step) + 1; i++)
        {

            invertBits = i * step;
            if (bitsString[invertBits] == '0')
            {
                bitsString = bitsString.Remove(invertBits, 1).Insert(invertBits, "1");
            }
            else
            {
                bitsString = bitsString.Remove(invertBits, 1).Insert(invertBits, "0");

            }
        }
        int count = 0;
        string bitsSeparated = string.Empty;
        foreach (char item in bitsString)
        {
            bitsSeparated += item.ToString();
            count++;
            if (count % 8 == 0)
            {
                Console.WriteLine(Convert.ToInt32(bitsSeparated, 2));
                bitsSeparated = string.Empty;
            }
        }
    }
}