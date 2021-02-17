using System;

namespace DZ_02_HW_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int daysInWeek = 7;
            int days = 366;
            int weeks = days / daysInWeek;

            Console.WriteLine("дней: {0}\nнедель: {1}", days, weeks);

            Console.ReadLine();
        }
    }
}
