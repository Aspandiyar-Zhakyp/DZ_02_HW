﻿using System;

namespace DZ_02_HW_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2х значное число: ");
            int number = Int32.Parse(Console.ReadLine());
            int dec = number / 10;
            int unt = number % 10;

            int sum = dec + unt;
            int mult = dec * unt;

            Console.WriteLine("Число десятков: " + dec);
            Console.WriteLine("Число единиц: " + unt);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + mult);

            Console.ReadLine();
        }
    }
}
