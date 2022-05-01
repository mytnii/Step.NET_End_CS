
using System;

namespace Task_4
{
    static class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int[,] matrix = new int[size, size];
            int number = 3;

            Random random = new Random();

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }

            for(int i = 0; i < size; i++)
            {
                for(int j =0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix[i, j] *= number;
                }
            }

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();

            int[,] matrix2 = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                for( int j = 0; j < size; j++)
                {
                    matrix2[i, j] = random.Next(0, 10);
                }
            }

            for( int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();

            int[,] matrix3 = new int[size, size];

            for( int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix3[i, j] = matrix2[i, j] + matrix[i, j];
                }
            }

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(matrix3[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();

            int[,] matrix4 = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; ++j)
                {
                    for(int k = 0; k < size; ++k)
                    {
                        matrix4[i, j] += matrix[i, k] * matrix2[k, j];
                    }
                }
            }

            for(int i = 0; i < size; ++i)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(matrix4[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}