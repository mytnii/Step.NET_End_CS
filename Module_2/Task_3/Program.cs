
using System;

namespace Task_3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string? str = Console.ReadLine();

            char[] arr;

            if(str != null)
            {
                arr = str.ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    if
                        (
                        arr[i] >= 'a' && arr[i] <= 'z' ||
                        arr[i] >= 'A' && arr[i] <= 'Z'
                        )
                    {
                        if
                            (
                            arr[i] >= 'x' && arr[i] <= 'z' ||
                            arr[i] >= 'X' && arr[i] <= 'Z'
                            )
                        {
                            arr[i] -= (char)23;
                        }
                        else
                        {
                            arr[i] += (char)3;
                        }
                    }
                    else if
                        (
                        arr[i] >= 'а' && arr[i] <= 'я' ||
                        arr[i] >= 'А' && arr[i] <= 'Я'
                        )
                    {
                        if
                            (
                            arr[i] >= 'э' && arr[i] <= 'я' ||
                            arr[i] >= 'Э' && arr[i] <= 'Я'
                            )
                        {
                            arr[i] -= (char)29;
                        }
                        else
                        {
                            arr[i] += (char)3;
                        }
                    }
                }

                for(int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine("\n");

                for (int i = 0; i < str.Length; i++)
                {
                    if
                        (
                        arr[i] >= 'a' && arr[i] <= 'z' ||
                        arr[i] >= 'A' && arr[i] <= 'Z'
                        )
                    {
                        if
                            (
                            arr[i] >= 'a' && arr[i] <= 'c' ||
                            arr[i] >= 'A' && arr[i] <= 'C'
                            )
                        {
                            arr[i] += (char)23;
                        }
                        else
                        {
                            arr[i] -= (char)3;
                        }
                    }
                    else if
                        (
                        arr[i] >= 'а' && arr[i] <= 'я' ||
                        arr[i] >= 'А' && arr[i] <= 'Я'
                        )
                    {
                        if
                            (
                            arr[i] >= 'а' && arr[i] <= 'в' ||
                            arr[i] >= 'А' && arr[i] <= 'В'
                            )
                        {
                            arr[i] += (char)29;
                        }
                        else
                        {
                            arr[i] -= (char)3;
                        }
                    }
                }
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
            }
        }
    }
}