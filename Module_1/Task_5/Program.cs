
using System;

namespace Task_5
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате дд.мм.гггг");
            string? str = Console.ReadLine();
            DateTime date;
            DateTime.TryParse(str, out date);

            if(str != null)
            {
            if(str.Length != 10)
            {
                    Console.WriteLine("Неправильный формат ввода");
                    return;
            }
            string strDate = date.ToString();
                for(int i = 0; i < 10; i++)
                {
                    if(str[i] != strDate[i])
                    {
                        Console.WriteLine("некоректный ввод");
                        return;
                    }
                }
            }
            Console.WriteLine(date);

            if(date.Month == 12 || date.Month == 1 || date.Month == 2)
            {
                Console.WriteLine($"Winter {date.DayOfWeek}");
            }
            else if(date.Month >= 3 && date.Month <= 5)
            {
                Console.WriteLine($"Spring {date.DayOfWeek}");
            }
            else if(date.Month >= 6 && date.Month <= 8)
            {
                Console.WriteLine($"Summer {date.DayOfWeek}");
            }
            else
            {
                Console.WriteLine($"Autumn {date.DayOfWeek}");  
            }
        }
    }
}