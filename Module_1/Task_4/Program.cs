/*
 Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число тре-
буется вывести сообщение об ошибке.
 */

using System;

namespace Task_4
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число");
            string? str = Console.ReadLine();

            if(str == null)
            {
                Console.WriteLine("Число не введено");
                return;
            }
            else if(str.Length != 6)
            {
                Console.WriteLine("введено не шестизначное число");
                return;
            }

            foreach(char c in str)
            {
                if(!char.IsDigit(c))
                {
                    Console.WriteLine("некоректный ввод числа");
                    return;
                }
            }

            Console.WriteLine("Введите первый разряд");

            int dischargeNum1;
            int.TryParse(Console.ReadLine(), out dischargeNum1);

            if(dischargeNum1 <= 0 || dischargeNum1 > 6)
            {
                Console.WriteLine("Некоректный ввод разряда");
                return;
            }

            Console.WriteLine("Введите второй разряд");

            int dischargeNum2;
            int.TryParse(Console.ReadLine(),out dischargeNum2);

            if(dischargeNum2 <= 0 || dischargeNum2 > 6)
            {
                Console.WriteLine("Некоректный ввод разряда");
                return;
            }

            int size;
            int.TryParse(str,out size);
            int value = 100000;

            int[] arr = new int[str.Length];

            for(int i = 0; i < str.Length; i++)
            {
                arr[i] = size / value;
                size %= value;
                value /= 10;
            }

            for(int i = 0; i < str.Length;i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();

            int number;

            if(dischargeNum1 < dischargeNum2)
            {
                for(int i = 0; i < str.Length; ++i)
                {
                    if(i == dischargeNum1 - 1)
                    {
                        for(int j = i; j < str.Length; ++j)
                        {
                            if(j == dischargeNum2 - 1)
                            {
                                number = arr[i];
                                arr[i] = arr[j];
                                arr[j] = number;
                                break;
                            }
                        }
                    }
                }
            }
            else if(dischargeNum1 > dischargeNum2)
            {
                for(int i = 0; i < str.Length; ++i)
                {
                    if(i == dischargeNum2 - 1)
                    {
                        for(int j = i; j < str.Length; ++j)
                        {
                            if(j == dischargeNum1 - 1)
                            {
                                number = arr[i];
                                arr[i] = arr[j];
                                arr[j] = number;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Введенные регистры одинаковае");
                return;
            }

            foreach(int i in arr)
            {
                Console.Write(i);
            }
        }
    }
}