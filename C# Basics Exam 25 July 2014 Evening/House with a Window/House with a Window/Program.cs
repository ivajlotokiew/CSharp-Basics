using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class House_with_a_Window
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numb = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', numb - 1), new string('.', numb - 1));
        for (int i = 1; i < numb; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', numb - 1 - i), new string('.', 2 * i - 1),
                new string('.', numb - 1 - i));
        }
        Console.WriteLine("{0}", new string('*', 2 * numb - 1));

        for (int i = 0; i < numb / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * numb - 3));

        }
        for (int i = 0; i < numb / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('.', ((2 * numb - 3) - (numb - 3)) / 2),
                new string('*', numb - 3), new string('.', ((2 * numb - 3) - (numb - 3)) / 2));
        }

        for (int i = 0; i < numb / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * numb - 3));

        }
        Console.WriteLine("{0}", new string('*', 2 * numb - 1));


    }
}