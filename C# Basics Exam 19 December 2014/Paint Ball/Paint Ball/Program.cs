using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Paint_Ball
{
    static void Main()
    {
        string coord = Console.ReadLine();
        int[] matrix = { 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023 };
        int count = 1;
        bool isZero = true;

        while (coord != "End")
        {

            string[] coordArray = coord.Split(' ');
            int numbMatrixElement = Convert.ToInt32(coordArray[0]);
            int numberBitToChange = Convert.ToInt32(coordArray[1]);
            if (isZero)
            {

                matrix[numbMatrixElement] &= ~(1 << numberBitToChange);

                while ((numberBitToChange + count <= 9) && (numberBitToChange + count != numberBitToChange + Convert.ToInt32(coordArray[2]) + 1))
                {
                    matrix[numbMatrixElement] &= ~(1 << (numberBitToChange + count));
                    count++;
                }
                count = 1;
                while ((numberBitToChange - count >= 0) && (numberBitToChange - count != numberBitToChange - Convert.ToInt32(coordArray[2]) - 1))
                {
                    matrix[numbMatrixElement] &= ~(1 << (numberBitToChange - count));
                    count++;
                }

                // The other elements
                count = 1;
                int countNumb = 1;

                while ((numbMatrixElement + countNumb <= 9) && (numbMatrixElement + countNumb != numbMatrixElement + Convert.ToInt32(coordArray[2]) + 1))
                {
                    matrix[numbMatrixElement + countNumb] &= ~(1 << numberBitToChange);

                    while ((numberBitToChange + count <= 9) && (numberBitToChange + count != numberBitToChange + Convert.ToInt32(coordArray[2]) + 1))
                    {
                        matrix[numbMatrixElement + countNumb] &= ~(1 << (numberBitToChange + count));
                        count++;
                    }
                    count = 1;
                    while ((numberBitToChange - count >= 0) && (numberBitToChange - count != numberBitToChange - Convert.ToInt32(coordArray[2]) - 1))
                    {
                        matrix[numbMatrixElement + countNumb] &= ~(1 << (numberBitToChange - count));
                        count++;
                    }
                    countNumb++;
                    count = 1;
                }
                count = 1;
                countNumb = 1;
                while ((numbMatrixElement - countNumb >= 0) && (numbMatrixElement - countNumb != numbMatrixElement - Convert.ToInt32(coordArray[2]) - 1))
                {
                    matrix[numbMatrixElement - countNumb] &= ~(1 << numberBitToChange);
                    while ((numberBitToChange + count <= 9) && (numberBitToChange + count != numberBitToChange + Convert.ToInt32(coordArray[2]) + 1))
                    {
                        matrix[numbMatrixElement - countNumb] &= ~(1 << (numberBitToChange + count));
                        count++;
                    }
                    count = 1;
                    while ((numberBitToChange - count >= 0) && (numberBitToChange - count != numberBitToChange - Convert.ToInt32(coordArray[2]) - 1))
                    {
                        matrix[numbMatrixElement - countNumb] &= ~(1 << (numberBitToChange - count));
                        count++;
                    }
                    countNumb++;
                    count = 1;
                }
                isZero = false;
            }


            else if (!isZero)
            {
                matrix[numbMatrixElement] |= 1 << numberBitToChange;

                while ((numberBitToChange + count <= 9) && (numberBitToChange + count != numberBitToChange + Convert.ToInt32(coordArray[2]) + 1))
                {
                    matrix[numbMatrixElement] |= 1 << (numberBitToChange + count);
                    count++;
                }
                count = 1;
                while ((numberBitToChange - count >= 0) && (numberBitToChange - count != numberBitToChange - Convert.ToInt32(coordArray[2]) - 1))
                {
                    matrix[numbMatrixElement] |= 1 << (numberBitToChange - count);
                    count++;
                }

                // The other elements
                count = 1;
                int countNumb = 1;

                while ((numbMatrixElement + countNumb <= 9) && (numbMatrixElement + countNumb != numbMatrixElement + Convert.ToInt32(coordArray[2]) + 1))
                {
                    matrix[numbMatrixElement + countNumb] |= 1 << numberBitToChange;

                    while ((numberBitToChange + count <= 9) && (numberBitToChange + count != numberBitToChange + Convert.ToInt32(coordArray[2]) + 1))
                    {
                        matrix[numbMatrixElement + countNumb] |= 1 << (numberBitToChange + count);
                        count++;
                    }
                    count = 1;
                    while ((numberBitToChange - count >= 0) && (numberBitToChange - count != numberBitToChange - Convert.ToInt32(coordArray[2]) - 1))
                    {
                        matrix[numbMatrixElement + countNumb] |= 1 << (numberBitToChange - count);
                        count++;
                    }
                    countNumb++;
                    count = 1;
                }
                count = 1;
                countNumb = 1;
                while ((numbMatrixElement - countNumb >= 0) && (numbMatrixElement - countNumb != numbMatrixElement - Convert.ToInt32(coordArray[2]) - 1))
                {
                    matrix[numbMatrixElement - countNumb] |= 1 << numberBitToChange;
                    while ((numberBitToChange + count <= 9) && (numberBitToChange + count != numberBitToChange + Convert.ToInt32(coordArray[2]) + 1))
                    {
                        matrix[numbMatrixElement - countNumb] |= 1 << (numberBitToChange + count);
                        count++;
                    }
                    count = 1;
                    while ((numberBitToChange - count >= 0) && (numberBitToChange - count != numberBitToChange - Convert.ToInt32(coordArray[2]) - 1))
                    {
                        matrix[numbMatrixElement - countNumb] |= 1 << (numberBitToChange - count);
                        count++;
                    }
                    countNumb++;
                    count = 1;
                }
                isZero = true;
            }
            coord = Console.ReadLine();
        }
        int sum = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            sum += matrix[i];

        }
        Console.WriteLine(sum);
    }
}