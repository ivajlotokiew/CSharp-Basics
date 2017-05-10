using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Tribonacci
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        BigInteger[] matrix = new BigInteger[3];
        matrix[0] = BigInteger.Parse(Console.ReadLine());
        matrix[1] = BigInteger.Parse(Console.ReadLine());
        matrix[2] = BigInteger.Parse(Console.ReadLine());
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger totalSum = 0;
        if (number == 1)
        {
            Console.WriteLine(matrix[0]);
        }
        else if (number == 2)
        {
            Console.WriteLine(matrix[0] + matrix[1]);

        }
        else if (number == 3)
        {
            Console.WriteLine(matrix[0] + matrix[1] + matrix[2]);

        }
        else
        {
            for (BigInteger i = 1; i <= number - 3; i++)
            {
                totalSum = matrix[0] + matrix[1] + matrix[2];
                matrix[0] = matrix[1];
                matrix[1] = matrix[2];
                matrix[2] = totalSum;
            }
            Console.WriteLine(totalSum);
        }
    }
}