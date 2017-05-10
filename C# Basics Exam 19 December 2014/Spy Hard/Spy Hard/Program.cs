using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Spy_Hard
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int number = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        int countSymbols = 0;
        int sumSymbols = 0;
        foreach (var item in message)
        {
            countSymbols++;
            if ((item >= 65 && item <= 90))
            {
                sumSymbols += item - 64;
            }
            else if ((item >= 97 && item <= 122))
            {
                sumSymbols += item - 96;
            }
            else
            {
                sumSymbols += item;
            }
        }
        //string concatSymbols = "" + number + countSymbols + Convert.ToString(sumSymbols, 2);
        //Console.WriteLine(concatSymbols);
        //Console.WriteLine("" + number + countSymbols + sumSymbols);
        Console.WriteLine("" + number + countSymbols + DecimalToBase(sumSymbols, number));


    }

    static string DecimalToBase(int number, int radix)
    {
        // Check that the radix is between 2 and 36 inclusive
        if (radix < 2 || radix > 36)
            throw new ArgumentException("ConvertToBase(int number, int radix) - Radix must be between 2 and 36.");

        // Create a buffer large enough to hold the largest int value represented in binary digits 
        StringBuilder result = new StringBuilder("                                ");  // 32 spaces

        // The base conversion calculates the digits in reverse order so use
        // an index to point to the last unused space in our buffer
        int i = 32;

        // Convert the number to the new base
        do
        {
            int remainder = number % radix;
            number = number / radix;
            if (remainder <= 9)
                result[--i] = (char)(remainder + '0');  // Converts [0..9] to ASCII ['0'..'9']
            else
                result[--i] = (char)(remainder + '7');  // Converts [10..36] to ASCII ['A'..'Z']
        } while (number > 0);

        // Remove the unwanted padding from the front of our buffer and return the result
        // Note i points to the last unused character in our buffer
        result.Remove(0, i);
        return (result.ToString());
    }
}