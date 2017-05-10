using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Morse_Code_Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string nSum = Console.ReadLine();
        int sum = 0;
        bool isResult = false;
        foreach (var item in nSum)
        {
            sum += Convert.ToInt32(item.ToString());
        }
        for (int i1 = 0; i1 < 6; i1++)
        {
            for (int i2 = 0; i2 < 6; i2++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    for (int i4 = 0; i4 < 6; i4++)
                    {
                        for (int i5 = 0; i5 < 6; i5++)
                        {
                            for (int i6 = 0; i6 < 6; i6++)
                            {
                                if (i1 * i2 * i3 * i4 * i5 * i6 == sum)
                                {
                                    stringCharahter(i1, i2, i3, i4, i5, i6);
                                    isResult = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!isResult)
        {
            Console.WriteLine("No");
        }
    }
    static void stringCharahter(int i1, int i2, int i3, int i4, int i5, int i6)
    {
        string[] morseCodes = { "-----", ".----", "..---", "...--", "....-", "....." };

        string morseNumber =
    morseCodes[i1] + "|" +
    morseCodes[i2] + "|" +
    morseCodes[i3] + "|" +
    morseCodes[i4] + "|" +
    morseCodes[i5] + "|" +
    morseCodes[i6] + "|";
        Console.WriteLine(morseNumber);

    }
}