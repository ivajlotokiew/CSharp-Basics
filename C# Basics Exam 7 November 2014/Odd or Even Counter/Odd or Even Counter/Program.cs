using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Text;

class Odd_Or_Even_Counter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int countOfSets = int.Parse(Console.ReadLine());
        int countNumbersOfSet = int.Parse(Console.ReadLine());
        string oddOrEven = Console.ReadLine();
        int numbers = 0;
        int totalNumbers = 0;
        int finalSet = 0;
        string totalSet = string.Empty;
        bool isSet = false;
        int[,] matrix = new int[countOfSets, countNumbersOfSet];
        for (int i = 0; i < countOfSets; i++)
        {
            for (int j = 0; j < countNumbersOfSet; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int row = 0; row < countOfSets; row++)
        {
            for (int col = 0; col < countNumbersOfSet; col++)
            {
                if (oddOrEven == "odd")
                {
                    if (matrix[row, col] % 2 != 0)
                    {
                        numbers++;
                        isSet = true;
                    }
                }
                else if (oddOrEven == "even")
                {
                    if (matrix[row, col] % 2 == 0)
                    {
                        numbers++;
                        isSet = true;
                    }
                }
            }
            if (totalNumbers < numbers)
            {
                totalNumbers = numbers;
                finalSet = row + 1;
            }
            numbers = 0;
        }

        switch (finalSet)
        {
            case 1: totalSet = "First"; break;
            case 2: totalSet = "Second"; break;
            case 3: totalSet = "Third"; break;
            case 4: totalSet = "Fourth"; break;
            case 5: totalSet = "Fifth"; break;
            case 6: totalSet = "Sixth"; break;
            case 7: totalSet = "Seventh"; break;
            case 8: totalSet = "Eighth"; break;
            case 9: totalSet = "Ninth"; break;
            case 10: totalSet = "Tenth"; break;

        }
  
        if (isSet)
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", totalSet, oddOrEven, totalNumbers);
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}