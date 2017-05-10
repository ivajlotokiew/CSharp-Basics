using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Plane
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numb = int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine("{0}*{0}", new string('.', 3 * numb / 2));

        for (int i = 0; i < (((numb * 3) - (numb / 2)) - 2 * (numb / 2 - 1) - (numb - 1)) - 3; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (3 * numb - 3 - 2 * i) / 2), new string('.', 2 * i + 1));
            sum = 2 * i + 1;
        }

        for (int i = 0; i < numb / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', ((3 * numb - (sum + 4 + 4 * i)) - 2) / 2),
                new string('.', sum + 4 + 4 * i));
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', numb - 2), new string('.', numb));

        for (int i = 0; i < numb / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', (3 * numb - 8 - numb) / 2 - 2 * i),
                new string('.', 1 + 2 * i), new string('.', numb));

        }

        for (int i = 0; i < numb - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', numb - 1 - i), new string('.', numb + 2 * i));

        }

        Console.WriteLine("{0}", new string('*', 3 * numb));

    }
}