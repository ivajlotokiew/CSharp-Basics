using System;

class Bit_Roller
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int maskF = 1 << f;
        int fBit = num & maskF;
        for (int i = 0; i < r; i++)
        {
            num &= ~maskF;
            int lastBit = 1 & num;
            lastBit <<= 18;
            num >>= 1;
            num |= lastBit;
            if ((num & maskF) == maskF)
            {
                num = num | (maskF >> 1);
            }
            num |= fBit;
        }

        Console.WriteLine(num);
    }
}