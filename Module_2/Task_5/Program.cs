
using System;

namespace Task_5
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите арифметическое выражение: сложение или вычитание");
            string? str = Console.ReadLine();
            char symbol = ' ';
            int value = 0;
            int value2 = 0;

            if(str != null)
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if(!char.IsDigit(str[i]) && str[i] != '+' && str[i] != '-')
                    {
                        Console.WriteLine("неправельный ввод арифметического выражения");
                        return;
                    }
                }
                for(int i = 0; i < str.Length; i++)
                {
                    if(str[i] == '+' || str[i] == '-')
                    {
                        symbol = str[i];
                    }
                }

                string[] number = str.Split(new char[] {symbol});

                int.TryParse(number[0], out value);
                int.TryParse(number[1], out value2);

                if(symbol == '+')
                {
                    Console.WriteLine($"{value} {symbol} {value2} =  {value + value2}");
                }
                else
                {
                    Console.WriteLine($"{value} {symbol} {value2} =  {value + value2}");

                }



            }
        }
    }
}