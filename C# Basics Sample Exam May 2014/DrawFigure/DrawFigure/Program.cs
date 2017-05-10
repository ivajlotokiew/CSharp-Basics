using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Sand_Glass
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int count = 0;
        int numb = int.Parse(Console.ReadLine());
        for (int i = 0; i < numb / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', numb - 2 * i), new string('.', i));
        }
        for (int i = 0; i < numb / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', numb / 2 - i - 1), new string('*', 3 + 2 * i),
                new string('.', numb / 2 - i - 1));
            count++;
        }

    }
}