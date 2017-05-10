using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class Arrow
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numb = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', numb / 2), new string('#', numb), new string('.', numb / 2));
        for (int i = 0; i < numb - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', numb / 2), new string('.', (numb - 2)), new string('.', numb / 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('#', (numb + 1) / 2), new string('.', numb - 2), new string('.', (numb + 1) / 2));
        for (int j = 0; j < numb - 2; j++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', j + 1), new string('.', (2 * numb - 5) - 2 * j), new string('.', j + 1));
        }
        Console.WriteLine("{0}#{0}", new string('.', numb - 1), new string('.', numb - 1));

    }
}