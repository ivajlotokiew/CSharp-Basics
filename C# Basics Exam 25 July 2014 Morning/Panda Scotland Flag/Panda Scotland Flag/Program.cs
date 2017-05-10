using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Panda_Scotland_Flag
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numb = int.Parse(Console.ReadLine());
        char result = (char)'@';

        for (int i = 1; i <= numb / 2; i++)
        {
            Console.Write("{0}", new string('~', i - 1));
            Console.Write("{0}", new string(++result, 1));
            if (result == 'Z')
            {
                result = '@';
            }
            Console.Write(new string('#', numb - 2 * i));
            Console.Write("{0}", new string(++result, 1));
            if (result == 'Z')
            {
                result = '@';
            }
            Console.WriteLine("{0}", new string('~', i - 1));
        }
        Console.WriteLine("{0}{1}{0}", new string('-', numb / 2), new string(++result, 1),
            new string('-', numb / 2));
        if (result == 'Z')
        {
            result = '@';
        }

        for (int i = 1; i <= numb / 2; i++)
        {
            Console.Write("{0}", new string('~', numb / 2 - i));
            Console.Write("{0}", new string(++result, 1));
            if (result == 'Z')
            {
                result = '@';
            }
            Console.Write(new string('#', 2 * i - 1));
            Console.Write("{0}", new string(++result, 1));
            if (result == 'Z')
            {
                result = '@';
            }
            Console.WriteLine("{0}", new string('~', numb / 2 - i));
        }
    }
}