using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

class The_Explorer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('-', N / 2), new string('-', N / 2));
        for (int i = 0; i < N / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', N / 2 - (i + 1)),
                new string('-', 2 * i + 1), new string('-', N / 2 - (i + 1)));
        }
        for (int i = N / 2; i > 1; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', N / 2 - (i - 1)),
                new string('-', N - (2 + 2 * (N / 2 - (i - 1)))), new string('-', N / 2 - (i - 1)));
        }
        Console.WriteLine("{0}*{0}", new string('-', N / 2), new string('-', N / 2));


    }
}