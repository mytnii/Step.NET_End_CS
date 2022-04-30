
using System;

namespace Task_1
{
    static class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] arr = new int[size];
            int row = 3;
            int column = 4;
            double[,] matrix = new double[row, column];
            string? str;

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите целое число");
                
                str = Console.ReadLine();
                int.TryParse(str, out arr[i]);

                if(arr[i] == 0 && str != "0")
                {
                    Console.WriteLine("Не коректный ввод числа");
                    return;
                }
            }

            Random rand = new Random();

            for(int i = 0;i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    matrix[i, j] = rand.Next(0, 10) + rand.NextDouble();
                }
            }
            Console.WriteLine();

            foreach(int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\r\n");

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\r\n");

            int maxArray = arr[0];

            foreach(int i in arr)
            {
                if(i > maxArray)
                {
                    maxArray = i;
                }
            }

            Console.WriteLine($"Максимальное значение массива: {maxArray}\r\n");

            double maxMatrix = matrix[0,0];

            for(int i = 0; i < row; ++i)
            {
                for(int j = 0; j < column; j++)
                {
                    if(maxMatrix < matrix[i, j])
                    {
                        maxMatrix = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Максимальное значение матрици: {maxMatrix}\r\n");

            int minArray = arr[0];

            for(int i = 0; i < size; ++i)
            {
                if(minArray > arr[i])
                {
                    minArray = arr[i];
                }
            }

            Console.WriteLine($"Минимальное значение массива: {minArray}\r\n");

            double minMatrix = matrix[0,0];

            for(int i = 0; i < row; i++)
            {
                for(int j = 0;j < column; j++)
                {
                    if(minMatrix > matrix[i, j])
                    {
                        minMatrix = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальное значение матрици: {minMatrix}\r\n");

            int sumArray = 0;

            foreach(int i in arr)
            {
                sumArray += i;
            }

            Console.WriteLine($"Сумма всех элементов массива: {sumArray}\r\n");

            double sumMatrix = 0;

            for(int i = 0; i < row; ++i)
            {
                for(int j = 0; j < column; j++)
                {
                    sumMatrix += matrix[i, j];
                }
            }

            Console.WriteLine($"Сумма всех элементов матрици: {sumMatrix}\r\n");

            long multiplicationArray = 1;

            foreach(int i in arr)
            {
                multiplicationArray *= i;
            }

            Console.WriteLine($"Произведение всех элементов массива: {multiplicationArray}\r\n");

            double multiplicationMatrix = 1.0;

            for( int i = 0; i < row; ++i)
            {
                for( int j = 0; j < column; ++j)
                {
                    multiplicationMatrix *= matrix[i, j]; ;
                }
            }

            Console.WriteLine($"Произведение всех элементов матрици: {multiplicationMatrix}\r\n");

            int sumEvenArray = 0;

            foreach (int i in arr)
            {
                if(i % 2 == 0)
                {
                    sumEvenArray += i;
                }
            }

            Console.WriteLine($"Сумма четных элементов массива: {sumEvenArray}\r\n");

            double sumOddColumnMatrix = 0;

            for(int i = 0; i < row; ++i)
            {
                for(int j = 0; j < column; ++j)
                {
                    if(j % 2 != 0)
                    {
                        sumOddColumnMatrix += matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Сумма нечетных столбцов матрици: {sumOddColumnMatrix}\r\n");
        }
    }
}