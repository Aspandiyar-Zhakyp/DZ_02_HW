﻿using System;

namespace DZ_02_HW_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, side;
            Console.WriteLine("У какой фигуры площадь больше?\n");

            Console.Write("Радиус круга: ");
            radius = Double.Parse(Console.ReadLine());

            Console.Write("Строна квадрата: ");
            side = Double.Parse(Console.ReadLine());

            double areaCircle = Math.PI * Math.Pow(radius, 2);
            double areaSqure = Math.Pow(side, 2);

            Console.WriteLine("\nПлощадь круга = " + areaCircle);
            Console.WriteLine("Площадь квадрата = " + areaSqure);

            string answer = areaCircle > areaSqure ? "круга" : "квадрата";
            Console.WriteLine("\nПлощадь {0} больше", answer);

            Console.ReadLine();
        }
    }
}
