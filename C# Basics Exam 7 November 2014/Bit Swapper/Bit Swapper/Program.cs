using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Half_Byte_Swapper
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ulong[] matrix = new ulong[4];
        for (int i = 0; i < 4; i++)
        {
            matrix[i] = ulong.Parse(Console.ReadLine());
        }
        string firstLine = Console.ReadLine();
        while (firstLine != "End")
        {
            string secondLine = Console.ReadLine();
            ulong currentNumbOne = (ulong)matrix[int.Parse(firstLine[0].ToString())];
            ulong currentNumbTwo = (ulong)matrix[int.Parse(secondLine[0].ToString())];
            int bitsNumberOne = Convert.ToInt32(firstLine[2].ToString());
            int bitsNumberTwo = Convert.ToInt32(secondLine[2].ToString());
            ulong one = 1;

            for (int i = 0; i < 4; i++)
            {
                ulong maskOne = one << (i + 4 * bitsNumberOne);
                ulong maskTwo = one << (i + 4 * bitsNumberTwo);

                bool caseOne = (currentNumbOne & maskOne) > 0 && (currentNumbTwo & maskTwo) == 0;
                bool caseTwo = (currentNumbOne & maskOne) == 0 && (currentNumbTwo & maskTwo) > 0;
                if (matrix[int.Parse(firstLine[0].ToString())] == matrix[int.Parse(secondLine[0].ToString())])
                {
                    if (caseOne)
                    {
                        currentNumbOne &= ~(maskOne);
                        currentNumbOne |= maskTwo;
                    }
                    if (caseTwo)
                    {
                        currentNumbOne |= maskOne;
                        currentNumbOne &= ~(maskTwo);
                    }
                    matrix[int.Parse(firstLine[0].ToString())] = currentNumbOne;
                }
                else
                {
                    if (caseOne)
                    {
                        currentNumbOne &= ~(maskOne);
                        currentNumbTwo |= maskTwo;
                    }
                    if (caseTwo)
                    {
                        currentNumbOne |= maskOne;
                        currentNumbTwo &= ~(maskTwo);
                    }
                    matrix[int.Parse(firstLine[0].ToString())] = currentNumbOne;
                    matrix[int.Parse(secondLine[0].ToString())] = currentNumbTwo;

                }
            }
            firstLine = Console.ReadLine();
        }
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(matrix[i]);
        }
    }
}