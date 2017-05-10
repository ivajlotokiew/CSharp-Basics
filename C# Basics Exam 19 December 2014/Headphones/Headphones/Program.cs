using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Headphones
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('-', ((2 * N + 1) - (N + 2)) / 2), new string('*', N + 2));

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', ((2 * N + 1) - (N + 2)) / 2), new string('-', N));
        }

        for (int i = 0; i < N / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', (N - 3) / 2 - i),
                                                 new string('*', 3 + 2 * i),
                                                 new string('-', ((2 * N + 1) - 2 * ((N - 3) / 2 - i) - 2 * (3 + 2 * i))));
        }

        for (int i = 0; i < N / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', i + 1),
                new string('*', ((2 * N + 1) - 2 * ((N - 3) / 2 - i) - 2 * (3 + 2 * i))),
                new string('-', 3 + 2 * i));
        }
    }
}