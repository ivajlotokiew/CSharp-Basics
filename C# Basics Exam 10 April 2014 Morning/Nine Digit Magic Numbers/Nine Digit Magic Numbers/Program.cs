using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class ine_Digit_Magic_Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int sum = int.Parse(Console.ReadLine());
        int sumCopy = sum;
        bool isResult = false;
        int diff = int.Parse(Console.ReadLine());
        int abc = 111;
        int def = diff + abc;
        int ghi = diff + def;
        string sumTripple = string.Empty;
        for (int i = 111; i < 778; i++)
        {
            abc = i;
            def = diff + abc;
            ghi = diff + def;
            if (ghi > 777) break;
            sumTripple = "" + abc + def + ghi;
            if (sumTripple.Contains("0") || sumTripple.Contains("8") || sumTripple.Contains("9"))
            {
                continue;
            }
            foreach (char item in sumTripple)
            {
                sum -= Convert.ToInt32(Convert.ToString(item));
            }
            if (sum == 0)
            {
                Console.WriteLine(sumTripple);
                isResult = true;
            }
            sum = sumCopy;
        }
        if (isResult == false)
        {
            Console.WriteLine("No");
        }

    }
}