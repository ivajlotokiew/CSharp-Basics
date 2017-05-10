using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Change_Even_Bits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int lastInput = int.Parse(Console.ReadLine());
        int lastInputCopy = lastInput;
        int countDigit = 0;
        int step = 0;
        int isBitChange = 0;
        int count = 0;

        while (count < n)
        {
            for (int i = 0; i < Convert.ToString(nums[count], 2).Length; i++)
            {
                countDigit++;
            }
            for (int i = 0; i < 64; i++)
            {
                if ((lastInput &= ~(1 << step)) == lastInputCopy)  //1111 0000
                {
                    isBitChange++;
                }
                step += 2;
                if (step >= countDigit * 2)
                {
                    break;
                }
                lastInput = lastInputCopy;
            }
            step = 0;
            for (int i = 0; i < 64; i++)
            {
                lastInput |= 1 << step;
                step += 2;

                if (step >= countDigit * 2)
                {
                    break;
                }
            }
            countDigit = 0;
            step = 0;
            count++;
            lastInputCopy = lastInput;
        }
        Console.WriteLine(lastInput);
        Console.WriteLine(isBitChange);
    }
}