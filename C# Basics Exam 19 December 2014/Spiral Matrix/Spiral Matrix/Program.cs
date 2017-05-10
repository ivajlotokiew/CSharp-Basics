using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Spiral_Matrix
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string direction = "right";
        int number = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();
        int[,] matrix = new int[number, number];
        int row = 0;
        int col = 0;
        int maxSum = 0;
        int countRow = 0;
        int totalRow = 0;
        int currentSum = 0;
        int matrixLength = number * number;
        for (int i = 1; i <= matrixLength; i++)
        {
            if ((direction == "right") && (col > number - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                row++;
                col--;
            }
            if ((direction == "down") && (row > number - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if ((direction == "left") && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                row--;
                col++;
            }
            if ((direction == "up") && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = i;

            if (direction == "right") col++;
            if (direction == "down") row++;
            if (direction == "left") col--;
            if (direction == "up") row--;
        }

        for (int r = 0; r < number; r++)
        {
            for (int c = 0; c < number; c++)
            {
                if (name[(matrix[r, c] - 1) % name.Length] >= 65 && name[(matrix[r, c] - 1) % name.Length] <= 90)
                {
                    currentSum += name[(matrix[r, c] - 1) % name.Length] - 64;
                }
                else if (name[(matrix[r, c] - 1) % name.Length] >= 97 && name[(matrix[r, c] - 1) % name.Length] <= 122)
                {
                    currentSum += name[(matrix[r, c] - 1) % name.Length] - 96;
                    countRow = r;
                }
            }

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
                totalRow = countRow;
            }
            currentSum = 0;
        }
        Console.WriteLine("{0} - {1}", totalRow, 10 * maxSum);
    }
}