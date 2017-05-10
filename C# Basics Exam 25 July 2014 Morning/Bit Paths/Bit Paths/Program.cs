using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Bit_Paths
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numberPaths = int.Parse(Console.ReadLine());
        int[,] matrix = new int[8, 4];
        string bitsString = string.Empty;
        int bitsInt = 0;
        int totalSum = 0;
        string hexValue = string.Empty;
        for (int i = 0; i < numberPaths; i++)
        {
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int row = 0;
            int result = 0;
            foreach (string item in inputNumbers)
            {
                int numb = Int32.Parse(item);
                result += Convert.ToInt32(item.ToString());
                if (matrix[row, result] == 0)
                {
                    matrix[row, result] = 1;
                }
                else if (matrix[row, result] > 0)
                {
                    matrix[row, result] = 0;
                }
                row++;
            }

        }
        for (int rows = 0; rows < 8; rows++)
        {
            for (int col = 0; col < 4; col++)
            {
                bitsString += "" + matrix[rows, col];
                bitsInt = Convert.ToInt32(bitsString, 2);
            }
            totalSum += bitsInt;
            bitsString = string.Empty;
            bitsInt = 0;
        }
        Console.WriteLine(Convert.ToString(totalSum, 2));
        Console.WriteLine(hexValue = totalSum.ToString("X"));
    }
}