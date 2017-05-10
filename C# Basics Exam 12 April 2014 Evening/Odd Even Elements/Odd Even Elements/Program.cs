using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class OddEvenElements
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double oddSum = 0;
        double oddMinNumber = double.MaxValue;
        double oddMaxNumber = double.MinValue;
        double evenSum = 0;
        double evenMinNumber = double.MaxValue;
        double evenMaxNumber = double.MinValue;
        bool isOdd = true;


        if (inputNumbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (inputNumbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", double.Parse(inputNumbers[0]), double.Parse(inputNumbers[0]), double.Parse(inputNumbers[0]));
        }
        else
        {
            foreach (string item in inputNumbers)
            {
                if (isOdd)
                {
                    if (oddMinNumber > double.Parse(item))
                    {
                        oddMinNumber = double.Parse(item);
                    }
                    if (oddMaxNumber < double.Parse(item))
                    {
                        oddMaxNumber = double.Parse(item);
                    }
                    oddSum += double.Parse(item);
                    isOdd = false;
                }
                else
                {
                    if (evenMinNumber > double.Parse(item))
                    {
                        evenMinNumber = double.Parse(item);
                    }
                    if (evenMaxNumber < double.Parse(item))
                    {
                        evenMaxNumber = double.Parse(item);
                    }
                    evenSum += double.Parse(item);
                    isOdd = true;
                }
            }
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum, oddMinNumber, oddMaxNumber, evenSum, evenMinNumber, evenMaxNumber);
        }

    }
}