using System;

namespace Task_2
{
    static class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] matrix = new int[size, size];
            Random random = new Random();

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                }
            }

            for(int i = 0; i < size; ++i)
            {
                for(int j = 0;j < size; ++j)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine("\n");
            }

            int minMatrix = matrix[0, 0];
            int minI = 0;
            int minJ = 0;

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; ++j)
                {
                    if(minMatrix > matrix[i, j])
                    {
                        minMatrix = matrix[i, j];
                        minI = i;
                        minJ = j;
                    }
                }
            }

            int maxMatrix = matrix[0, 0];
            int maxI = 0;
            int maxJ = 0;

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(maxMatrix < matrix[i, j])
                    {
                        maxMatrix = matrix[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            int sumItemMatrix = 0;

            if(minI < maxI)
            {
                for(int i = minI; i <= maxI; ++i)
                {
                  for(int j = 0; j < size; j++)
                    {
                        if(i == minI && j >= minJ)
                        {
                            Console.WriteLine($"{sumItemMatrix} + {matrix[i, j]} = {sumItemMatrix + matrix[i, j]}\n");
                            sumItemMatrix += matrix[i, j];
                        }
                        else if( i <= maxI && i != minI)
                        {
                            if (j == maxJ && i == maxI)
                            {
                                Console.WriteLine($"{sumItemMatrix} + {matrix[i, j]} = {sumItemMatrix + matrix[i, j]}\n");
                                sumItemMatrix += matrix[i, j];
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{sumItemMatrix} + {matrix[i, j]} = {sumItemMatrix + matrix[i, j]}\n");
                                sumItemMatrix += matrix[i, j];
                            }
                        }
                    }
                }
            }
            else if(minI > maxI)
            {
                for(int i = maxI; i <= minI; ++i)
                {
                    for(int j = 0; j < size; j++)
                    {
                        if(i == maxI && j >= maxJ)
                        {
                            Console.WriteLine($"{sumItemMatrix} + {matrix[i, j]} = {sumItemMatrix + matrix[i, j]}\n");
                            sumItemMatrix += matrix[i, j];

                        }
                        else if(i <= minI && i != maxI)
                        {
                            if (j == minJ && i == minI)
                            {
                                Console.WriteLine($"{sumItemMatrix} + {matrix[i, j]} = {sumItemMatrix + matrix[i, j]}\n");
                                sumItemMatrix += matrix[i, j];
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{sumItemMatrix} + {matrix[i, j]} = {sumItemMatrix + matrix[i, j]}\n");

                                sumItemMatrix += matrix[i, j];
                            }
                        }
                    }
                }
            }
            else
            {
                if(minJ < maxJ)
                {
                    for(int i = minJ; i <= maxJ; ++i)
                    {
                        Console.WriteLine($"{sumItemMatrix} + {matrix[minI, i]} = {sumItemMatrix + matrix[minI, i]}\n");
                        sumItemMatrix += matrix[minI, i];
                    }
                }
                else if(minJ > maxJ)
                {
                    for(int i = maxJ; i <= minJ; ++i)
                    {
                        Console.WriteLine($"{sumItemMatrix} + {matrix[minI, i]} = {sumItemMatrix + matrix[minI, i]}\n");
                        sumItemMatrix += matrix[minI, i];
                    }
                }
                else
                {
                    Console.WriteLine("Индекс минимального элемента равен индексу максимального элемента");
                }
            }

            Console.WriteLine
                (
                @$"
Махсимальный элемент:{maxMatrix}
Минимальный элемент: {minMatrix}"
                );

            Console.WriteLine($"Сумма елементов в диапозоне от минимального элемента до махсимального: {sumItemMatrix}");
        }
    }
}