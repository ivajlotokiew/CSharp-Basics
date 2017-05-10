using System;
using System.Threading;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

class Bulls_and_Cows
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string secretNumber = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        //int numberFour = secretNumber % 10;
        //secretNumber = secretNumber / 10;
        //int numberTree = secretNumber % 10;
        //secretNumber = secretNumber / 10;
        //int numberTwo = secretNumber % 10;
        //secretNumber = secretNumber / 10;
        //int numberOne = secretNumber % 10;
        int countCows = 0;
        int countBulls = 0;
        int count = 0;

        for (int i1 = 1; i1 <= 9; i1++)
        {
            for (int i2 = 1; i2 <= 9; i2++)
            {
                for (int i3 = 1; i3 <= 9; i3++)
                {
                    for (int i4 = 1; i4 <= 9; i4++)
                    {
                        //if ((i1 == numberOne && i1 == numberTwo && i1 == numberTree && i1 == numberFour) &&
                        //(i2 == numberOne && i2 == numberTwo && i2 == numberTree && i2 == numberFour) &&
                        //(i3 == numberOne && i3 == numberTwo && i3 == numberTree && i3 == numberFour) &&
                        //(i4 == numberOne && i4 == numberTwo && i4 == numberTree && i4 == numberFour))
                        //{

                        //}
                        int numberA = Convert.ToInt32(secretNumber[0].ToString());
                        int numberB = Convert.ToInt32(secretNumber[1].ToString());
                        int numberC = Convert.ToInt32(secretNumber[2].ToString());
                        int numberD = Convert.ToInt32(secretNumber[3].ToString());
                        int currentCountA = i1;
                        int currentCountB = i2;
                        int currentCountC = i3;
                        int currentCountD = i4;

                        if (((bulls + cows) > 4) && (bulls == 3 && cows == 1))
                        {
                            Console.WriteLine("No");
                            break;
                        }
                        else
                        {
                            if (numberA == currentCountA)
                            {
                                numberA = -1;
                                currentCountA = -2;
                                countBulls++;
                            }
                            if (numberB == currentCountB)
                            {
                                numberB = -1;
                                currentCountB = -2;
                                countBulls++;
                            }
                            if (numberC == currentCountC)
                            {
                                numberC = -1;
                                currentCountC = -2;
                                countBulls++;
                            }
                            if (numberD == currentCountD)
                            {
                                numberD = -1;
                                currentCountD = -2;
                                countBulls++;
                            }
                            if ((numberA == currentCountB))
                            {
                                numberA = -3;
                                currentCountB = -4;
                                countCows++;
                            }
                            if ((numberA == currentCountC))
                            {
                                numberA = -3;
                                currentCountC = -4;
                                countCows++;
                            }
                            if ((numberA == currentCountD))
                            {
                                numberA = -3;
                                currentCountD = -4;
                                countCows++;
                            }

                            if ((numberB == currentCountA))
                            {
                                numberB = -3;
                                currentCountA = -4;
                                countCows++;
                            }
                            if ((numberB == currentCountC))
                            {
                                numberB = -3;
                                currentCountC = -4;
                                countCows++;
                            }
                            if ((numberB == currentCountD))
                            {
                                numberB = -3;
                                currentCountD = -4;
                                countCows++;
                            }


                            if ((numberC == currentCountA))
                            {
                                numberC = -3;
                                currentCountA = -4;
                                countCows++;
                            }
                            if ((numberC == currentCountB))
                            {
                                numberC = -3;
                                currentCountB = -4;
                                countCows++;
                            }
                            if ((numberC == currentCountD))
                            {
                                numberC = -3;
                                currentCountD = -4;
                                countCows++;
                            }

                            if ((numberD == currentCountA))
                            {
                                numberD = -3;
                                currentCountA = -4;
                                countCows++;
                            }
                            if ((numberD == currentCountB))
                            {
                                numberD = -3;
                                currentCountB = -4;
                                countCows++;
                            }
                            if ((numberD == currentCountC))
                            {
                                numberD = -3;
                                currentCountC = -4;
                                countCows++;
                            }

                        }
                        if ((countBulls == bulls) && (countCows == cows))
                        {
                            count++;
                            Console.Write("{0}{1}{2}{3} ", i1, i2, i3, i4);
                            countCows = 0;
                            countBulls = 0;
                        }
                        else
                        {
                            countCows = 0;
                            countBulls = 0;
                        }
                    }
                }
            }
        }
        if (count == 0) Console.Write("No");
        Console.WriteLine();
    }
}