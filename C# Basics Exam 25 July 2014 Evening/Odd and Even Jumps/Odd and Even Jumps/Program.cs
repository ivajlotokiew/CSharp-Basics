using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Odd_and_Even_Jumps
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string inputString = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        string inputStringToLower = inputString.ToLower().Replace(" ", "");
        bool isOdd = true;
        string stringOdd = string.Empty;
        string stringEven = string.Empty;
        int result = 0;
        int count = 0;
        BigInteger totalOddSum = 0;
        BigInteger totalEvenSum = 0;
        foreach (var item in inputStringToLower)
        {
            if (isOdd)
            {
                stringOdd += item;
                isOdd = false;
            }
            else if (!isOdd)
            {
                stringEven += item;
                isOdd = true;
            }
        }

        if (oddJump == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            while (count <= stringOdd.Length - 2)
            {
                for (int i = 0; i < oddJump - 1; i++)
                {
                    result += stringOdd[count];
                    count++;
                    if ((count == stringOdd.Length - 1) && (i < oddJump - 2))
                    {
                        totalOddSum += result + stringOdd[count];
                        break;
                    }
                    else if ((count == stringOdd.Length - 1) && (i == oddJump - 2))
                    {
                        totalOddSum = (totalOddSum + result) * stringOdd[count];
                        break;
                    }
                }
                if (count == stringOdd.Length - 1)
                {
                    break;
                }
                totalOddSum = (totalOddSum + result) * stringOdd[count];
                count++;
                if (count == stringOdd.Length - 1)
                {
                    totalOddSum += stringOdd[count];
                    break;
                }
                result = 0;
            }
        }

        if (evenJump == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            count = 0;
            result = 0;
            while (count <= stringEven.Length - 2)
            {
                for (int i = 0; i < evenJump - 1; i++)
                {
                    result += stringEven[count];
                    count++;
                    if ((count == stringEven.Length - 1) && (i < evenJump - 2))
                    {
                        totalEvenSum += result + stringEven[count];
                        break;
                    }
                    else if ((count == stringEven.Length - 1) && (i == evenJump - 2))
                    {
                        totalEvenSum = (totalEvenSum + result) * stringEven[count];
                        break;
                    }
                }
                if (count == stringEven.Length - 1)
                {
                    break;
                }
                totalEvenSum = (totalEvenSum + result) * stringEven[count];
                count++;
                if (count == stringEven.Length - 1)
                {
                    totalEvenSum += stringEven[count];
                    break;
                }
                result = 0;
            }
        }

        Console.WriteLine("Odd: {0}", totalOddSum.ToString("X").TrimStart('0').TrimEnd('0'));
        Console.WriteLine("Even: {0}", totalEvenSum.ToString("X").TrimStart('0').TrimEnd('0'));
    }
}