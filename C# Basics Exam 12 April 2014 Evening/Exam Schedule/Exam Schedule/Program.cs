using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class ExamSchedule
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int startHourExam = int.Parse(Console.ReadLine());
        int startMinutesExam = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHourExam = int.Parse(Console.ReadLine());
        int durationMinutesExam = int.Parse(Console.ReadLine());
        int endsHoursExam = 0;
        int endMinutesExam = 0;
        if (startMinutesExam + durationMinutesExam >= 60)
        {
            endsHoursExam = startHourExam + durationHourExam + 1;
            endMinutesExam = startMinutesExam + durationMinutesExam - 60;
            if ((partOfDay == "AM") && (endsHoursExam > 12))
            {
                endsHoursExam = endsHoursExam - 12;
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:PM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }

            }
            else if ((partOfDay == "PM") && (endsHoursExam > 12))
            {
                endsHoursExam = endsHoursExam - 12;
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:AM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "AM") && (endsHoursExam == 12))
            {
                if (endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endMinutesExam >= 10)
                {
                    Console.WriteLine("{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "PM") && (endsHoursExam == 12))
            {
                if (endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endMinutesExam >= 10)
                {
                    Console.WriteLine("{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "AM") && (endsHoursExam < 12))
            {
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:AM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "PM") && (endsHoursExam < 12))
            {
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:PM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
            }
        }

        else
        {
            endsHoursExam = startHourExam + durationHourExam;
            endMinutesExam = startMinutesExam + durationMinutesExam;
            if ((partOfDay == "AM") && (endsHoursExam > 12))
            {
                endsHoursExam = endsHoursExam - 12;
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:PM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }

            }
            else if ((partOfDay == "PM") && (endsHoursExam > 12))
            {
                endsHoursExam = endsHoursExam - 12;
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:AM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "AM") && (endsHoursExam < 12))
            {
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:AM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "PM") && (endsHoursExam < 12))
            {
                if (endsHoursExam < 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("0{0}:0{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam < 10 && endMinutesExam >= 10)
                {
                    Console.WriteLine("0{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endsHoursExam >= 10 && endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:PM", endsHoursExam, endMinutesExam);

                }
                else
                {
                    Console.WriteLine("{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "AM") && (endsHoursExam == 12))
            {
                if (endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:PM", endsHoursExam, endMinutesExam);
                }
                else if (endMinutesExam >= 10)
                {
                    Console.WriteLine("{0}:{1}:PM", endsHoursExam, endMinutesExam);
                }
            }
            else if ((partOfDay == "PM") && (endsHoursExam == 12))
            {
                if (endMinutesExam < 10)
                {
                    Console.WriteLine("{0}:0{1}:AM", endsHoursExam, endMinutesExam);
                }
                else if (endMinutesExam >= 10)
                {
                    Console.WriteLine("{0}:{1}:AM", endsHoursExam, endMinutesExam);
                }
            }
        }


    }
}