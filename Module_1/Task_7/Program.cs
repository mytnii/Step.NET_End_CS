
using System;

namespace Task_7
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало диапозон");

            string? str = Console.ReadLine();
            int startRange;
            int.TryParse(str, out startRange);

            if(startRange == 0 && str != "0")
            {
                Console.WriteLine("Не коректный ввод началного диапозона");
                return;
            }

            Console.WriteLine("введите конец диапозона");

            str = Console.ReadLine();
            int endRange;
            int.TryParse(str, out endRange);

            if(endRange == 0 && str != "0")
            {
                Console.WriteLine("Не коректный ввод конца диапозона");
                return;
            }

            if(startRange < endRange)
            {
                for(int i = startRange; i < endRange; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(i + "\t");
                    }
                }
            }
            else if(startRange > endRange)
            {
                for(int i = endRange; i < startRange; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(i + "\t");
                    }
                }
            }
            else
            {
                Console.WriteLine("Началный диапозон и конечный диапозон одинаковые");
            }
        }
    }
}