using System;

namespace DZ_02_HW_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 5;
            int numberTwo = 10;
            int numberThree = 21;

            Console.WriteLine("v1");
            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);

            Console.WriteLine("\nv2");
            Console.WriteLine(numberOne + "\n" + numberTwo + "\n" + numberThree);

            Console.WriteLine("\nv3");
            Console.WriteLine("{0}\n{1}\n{2}", numberOne, numberTwo, numberThree);

            Console.WriteLine("\nv4");
            int[] array = { 5, 10, 21 };
            foreach (int i in array)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
