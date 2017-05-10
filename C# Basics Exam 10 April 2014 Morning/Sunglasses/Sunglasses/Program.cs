using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

class Sunglasses
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("*{0}*{1}*{0}*", new string('*', 2 * N - 2), new string(' ', N), new string('*', 2 * N - 2));

        for (int i = 0; i < N / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * N - 2), new string(' ', N), new string('/', 2 * N - 2));
        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * N - 2), new string('|', N), new string('/', 2 * N - 2));
        for (int i = 0; i < N / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * N - 2), new string(' ', N), new string('/', 2 * N - 2));
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('*', 2 * N - 2), new string(' ', N), new string('*', 2 * N - 2));


    }
}