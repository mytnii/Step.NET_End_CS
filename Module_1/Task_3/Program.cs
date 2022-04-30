/*
 Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. На-
пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578.
 */

using System;

namespace Task_3
{
    static class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите число от 1 до 9");
                string? str = Console.ReadLine();
                int value;
                int.TryParse(str, out value);

                if(value == 0 && str != "0")
                {
                    Console.WriteLine("Некоректный ввод числа");
                    return;
                }
                else if(value < 1 || value > 9)
                {
                    Console.WriteLine("Введено число не из указанного диапозона");
                    return;
                }
                else
                {
                    number *= 10;
                    number += value;
                }
            }
            Console.WriteLine(number);
        }
    }
}