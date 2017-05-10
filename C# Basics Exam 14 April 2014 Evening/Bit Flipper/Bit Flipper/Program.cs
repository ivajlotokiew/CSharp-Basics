using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class Bit_Flipper
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ulong numb = ulong.Parse(Console.ReadLine());
        ulong numbCopy = numb;
        ulong seven = 7;
        int bit = 61;
        while (bit >= 0)
        {
            ulong mask = seven << bit;
            if ((numb | mask) == numb)
            {
                numb &= ~(mask);
                bit -= 3;
            }

            else if ((numb & ~mask) == numb)
            {
                numb |= mask;
                bit -= 3;
            }
            else bit--;
        }

        Console.WriteLine(numb);
    }
}