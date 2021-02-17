using System;

namespace DZ_02_HW_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;

            bool result1 = A || B;
            bool result2 = A && B;
            bool result3 = B || C;

            Console.WriteLine("A || B = " + result1);
            Console.WriteLine("A && B = " + result2);
            Console.WriteLine("B || C = " + result3);

            Console.ReadLine();
        }
    }
}
