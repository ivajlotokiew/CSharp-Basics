using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class ProgrammerDNA
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numb = int.Parse(Console.ReadLine());
        char symb = char.Parse(Console.ReadLine());
        int alph = symb - 65;
        int whole = numb / 7;
        int rest = numb % 7;

        while (whole > 0)
        {
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0: Console.WriteLine("{0}{1}{0}", new string('.', 3), (char)(alph++ % 7 + 65)); break;
                    case 1: Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', 2), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 2: Console.WriteLine("{0}{1}{2}{3}{4}{5}{0}", new string('.', 1), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 3: Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 4: Console.WriteLine("{0}{1}{2}{3}{4}{5}{0}", new string('.', 1), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 5: Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', 2), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 6: Console.WriteLine("{0}{1}{0}", new string('.', 3), (char)(alph++ % 7 + 65)); break;

                }
            }
            whole--;
        }
        if (rest == 0) return;
        else
        {
            for (int i = 0; i < rest; i++)
            {
                switch (i)
                {
                    case 0: Console.WriteLine("{0}{1}{0}", new string('.', 3), (char)(alph++ % 7 + 65)); break;
                    case 1: Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', 2), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 2: Console.WriteLine("{0}{1}{2}{3}{4}{5}{0}", new string('.', 1), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 3: Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 4: Console.WriteLine("{0}{1}{2}{3}{4}{5}{0}", new string('.', 1), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 5: Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', 2), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65), (char)(alph++ % 7 + 65)); break;
                    case 6: Console.WriteLine("{0}{1}{0}", new string('.', 3), (char)(alph++ % 7 + 65)); break;

                }
            }
        }

    }
}