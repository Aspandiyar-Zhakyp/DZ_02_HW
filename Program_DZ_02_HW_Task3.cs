using System;

namespace DZ_02_HW_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сантиметры в полные метры\n");
            Console.Write("СМ: ");
            int sm = Int32.Parse(Console.ReadLine());
            int m = (int)(sm * .001);
            Console.Write("М: " + m);

            Console.ReadLine();
        }
    }
}
