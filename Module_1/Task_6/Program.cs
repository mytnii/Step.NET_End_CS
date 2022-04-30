
using System;

namespace Task_6
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру");
            string? str = Console.ReadLine();

            double temperature;
            double.TryParse(str, out temperature);

            if(temperature == 0 && str != "0")
            {
                Console.WriteLine("Некоректный ввод температуры");
                return;
            }
            Console.WriteLine("Выберете во что перевести");
            Console.WriteLine("1 - из Фаренгейта в Цельсий");
            Console.WriteLine("2 - из Цельсия в Фаренгейт");
            str = Console.ReadLine();

            int value;
            int.TryParse(str, out value);

            switch(value)
            {
                case 1:
                    {
                        Console.WriteLine($"{temperature} по Фаренгейту: {(temperature - 32) / 1.8} Цельсия");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"{temperature} по Целсию: {temperature * 1.8 + 32} Фаренгейта");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Некоректный ввод выбора");
                        break;
                    }
            }
        }
    }
}