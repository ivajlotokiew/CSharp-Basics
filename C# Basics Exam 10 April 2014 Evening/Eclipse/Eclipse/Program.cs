using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class Eclipse
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numb = int.Parse(Console.ReadLine());
        Console.WriteLine(" {0} {1} {0} ", new string('*', 2 * numb - 2), new string(' ', numb - 1), new string('*', 2 * numb - 2));
        if (numb == 3)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * numb - 2), new string('-', numb - 1), new string('/', 2 * numb - 2));
        }
        else
        {
            for (int i = 0; i < numb / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * numb - 2), new string(' ', numb - 1), new string('/', 2 * numb - 2));

            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * numb - 2), new string('-', numb - 1), new string('/', 2 * numb - 2));

            for (int i = 0; i < numb / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * numb - 2), new string(' ', numb - 1), new string('/', 2 * numb - 2));

            }
        }
        Console.WriteLine(" {0} {1} {0} ", new string('*', 2 * numb - 2), new string(' ', numb - 1), new string('*', 2 * numb - 2));

    }
}