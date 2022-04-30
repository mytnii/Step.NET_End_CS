/*
 Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.
 */

using System;

namespace Task_2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение");
            double value;
            double.TryParse(Console.ReadLine(), out value);

            if(value <= 0)
            {
                Console.WriteLine("Неправильный ввод значения");
                return;
            }

            Console.WriteLine("Введите вычисляемый процент");
            int interest;
            int.TryParse(Console.ReadLine(), out interest);

            if(interest <= 0)
            {
                Console.WriteLine("Неправильный ввод процента");
                return;
            }

            Console.WriteLine($"{interest} процентов от {value}: {value / 100 * interest}");
        }
    }
}