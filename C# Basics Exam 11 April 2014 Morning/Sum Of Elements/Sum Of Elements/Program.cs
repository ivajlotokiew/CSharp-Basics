using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

class Sum_of_Elements
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[inputNumbers.Length];
        numbers = Array.ConvertAll<string, int>(inputNumbers, int.Parse);
        int totalSum = 0;
        int maxElement = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (maxElement < numbers[i])
            {
                maxElement = numbers[i];
            }
            totalSum += numbers[i];
        }
        if ((totalSum - maxElement) == maxElement)
        {
            Console.WriteLine("Yes, sum={0}", Math.Abs(maxElement));
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(totalSum - 2 * maxElement));
        }
    }
}