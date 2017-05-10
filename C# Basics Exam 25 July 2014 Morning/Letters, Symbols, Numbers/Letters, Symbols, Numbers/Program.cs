using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Letters__Symbols__Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int countInputStrings = int.Parse(Console.ReadLine());
        int sumAlphabets = 0;
        int sumASymbols = 0;
        int sumDigits = 0;
        for (int i = 0; i < countInputStrings; i++)
        {
            string stringValue = Console.ReadLine();

            foreach (char item in stringValue)
            {

                if ((item >= 65 && item <= 90) || (item >= 97 && item <= 122))
                {
                    switch (item)
                    {
                        case 'a': sumAlphabets += 10; break;
                        case 'b': sumAlphabets += 20; break;
                        case 'c': sumAlphabets += 30; break;
                        case 'd': sumAlphabets += 40; break;
                        case 'e': sumAlphabets += 50; break;
                        case 'f': sumAlphabets += 60; break;
                        case 'g': sumAlphabets += 70; break;
                        case 'h': sumAlphabets += 80; break;
                        case 'i': sumAlphabets += 90; break;
                        case 'j': sumAlphabets += 100; break;
                        case 'k': sumAlphabets += 110; break;
                        case 'l': sumAlphabets += 120; break;
                        case 'm': sumAlphabets += 130; break;
                        case 'n': sumAlphabets += 140; break;
                        case 'o': sumAlphabets += 150; break;
                        case 'p': sumAlphabets += 160; break;
                        case 'q': sumAlphabets += 170; break;
                        case 'r': sumAlphabets += 180; break;
                        case 's': sumAlphabets += 190; break;
                        case 't': sumAlphabets += 200; break;
                        case 'u': sumAlphabets += 210; break;
                        case 'v': sumAlphabets += 220; break;
                        case 'w': sumAlphabets += 230; break;
                        case 'x': sumAlphabets += 240; break;
                        case 'y': sumAlphabets += 250; break;
                        case 'z': sumAlphabets += 260; break;
                        case 'A': sumAlphabets += 10; break;
                        case 'B': sumAlphabets += 20; break;
                        case 'C': sumAlphabets += 30; break;
                        case 'D': sumAlphabets += 40; break;
                        case 'E': sumAlphabets += 50; break;
                        case 'F': sumAlphabets += 60; break;
                        case 'G': sumAlphabets += 70; break;
                        case 'H': sumAlphabets += 80; break;
                        case 'I': sumAlphabets += 90; break;
                        case 'J': sumAlphabets += 100; break;
                        case 'K': sumAlphabets += 110; break;
                        case 'L': sumAlphabets += 120; break;
                        case 'M': sumAlphabets += 130; break;
                        case 'N': sumAlphabets += 140; break;
                        case 'O': sumAlphabets += 150; break;
                        case 'P': sumAlphabets += 160; break;
                        case 'Q': sumAlphabets += 170; break;
                        case 'R': sumAlphabets += 180; break;
                        case 'S': sumAlphabets += 190; break;
                        case 'T': sumAlphabets += 200; break;
                        case 'U': sumAlphabets += 210; break;
                        case 'V': sumAlphabets += 220; break;
                        case 'W': sumAlphabets += 230; break;
                        case 'X': sumAlphabets += 240; break;
                        case 'Y': sumAlphabets += 250; break;
                        case 'Z': sumAlphabets += 260; break;
                    }
                }
                else if (item > 48 && item <= 57)
                {
                    switch (item)
                    {
                        case '1': sumDigits += 20; break;
                        case '2': sumDigits += 40; break;
                        case '3': sumDigits += 60; break;
                        case '4': sumDigits += 80; break;
                        case '5': sumDigits += 100; break;
                        case '6': sumDigits += 120; break;
                        case '7': sumDigits += 140; break;
                        case '8': sumDigits += 160; break;
                        case '9': sumDigits += 180; break;

                    }
                }
                else
                {
                    if (item == '`' || item == '~' || item == '!' || item == '@' || item == '#' ||
                        item == '$' || item == '%' || item == '^' || item == '&' || item == '*' ||
                        item == '(' || item == ')' || item == '_' || item == '+' || item == '{' ||
                        item == '}' || item == ':' || item == '"' || item == '|' || item == '<' ||
                        item == '>' || item == '?' || item == '-' || item == '=' || item == '[' ||
                        item == '[' || item == ']' || item == ';' || item == '\'' || item == '[' ||
                        item == '\\' || item == '.' || item == ',' || item == '/')
                    {
                        sumASymbols += 200;
                    }
                }


            }

        }
        Console.WriteLine(sumAlphabets);
        Console.WriteLine(sumDigits);
        Console.WriteLine(sumASymbols);
    }
}