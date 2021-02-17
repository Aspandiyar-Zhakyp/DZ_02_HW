using System;

namespace DZ_02_HW_Task_9
{
    class Program
    {
        static double Current(double resistance, double voltage)
        {
            return voltage / resistance;
        }

        static void Main(string[] args)
        {
            double resistance1, voltage1, resistance2, voltage2;

            Console.WriteLine("По какому участку цепи проходит меньший ток?\n");

            Console.WriteLine("Участок 1");
            Console.Write("Сопротивление: ");
            resistance1 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage1 = Double.Parse(Console.ReadLine());

            double elCurrent1 = Current(resistance1, voltage1);
            Console.WriteLine("Ток: " + elCurrent1);

            Console.WriteLine("\nУчасток 2");
            Console.Write("Сопротивление: ");
            resistance2 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage2 = Double.Parse(Console.ReadLine());

            double elCurrent2 = Current(resistance2, voltage2);
            Console.WriteLine("Ток: " + elCurrent2);

            string answer = elCurrent1 < elCurrent2 ? "первому" : "второму";
            Console.WriteLine("\nМеньший ток проходит по {0} участку цепи", answer);

            Console.ReadLine();
        }
    }
}
