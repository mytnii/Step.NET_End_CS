
using System;

namespace Task_7
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string? str = Console.ReadLine();
<<<<<<< HEAD
            char[]? text = new char[str != null ? str.Length : 0];
            if(text.Length == 0)
            {
                Console.WriteLine("Текст не введен");
                return;
            }
            Console.WriteLine("Введите недопустимое слово");
            string? word = Console.ReadLine();
            if(word == null)
            {
                Console.WriteLine("Недопустимое слово не введено");
                return;
            }
            bool flag = false;
          

            for(int i = 0; i < str?.Length; i++)
=======
            char[]? text = new char[str.Length];
            Console.WriteLine("Введите недопустимое слово");
            string? word = Console.ReadLine();
            bool flag = false;
          

            for(int i = 0; i < str.Length; i++)
>>>>>>> 2e9e303fca299a8d28228e6261e6f73fc3905722
            {
                text[i] = str[i];
            }

            for (int i = 0; i < text?.Length; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();

           for(int i = 0; i < text?.Length; i++)
            {
<<<<<<< HEAD
                if(text[i] == word?[0])
=======
                if(text[i] == word[0])
>>>>>>> 2e9e303fca299a8d28228e6261e6f73fc3905722
                {
                    for(int j = 0; j < word.Length; j++)
                    {
                        if(text[i + j] != word[j])
                        {
                            flag = false;
                            i = j;
                            break;
                        }
                        flag = true;
                    }

                    if(flag)
                    {
                        for(int j = 0; j < word.Length; j++)
                        {
                            text[i++] = '*';

                            if(j == word.Length - 1)
                            {
                                i = j;
                            }
                        }
                    }
                }
            }

<<<<<<< HEAD
            for (int i = 0; i < text?.Length; i++)
=======
            for (int i = 0; i < str?.Length; i++)
>>>>>>> 2e9e303fca299a8d28228e6261e6f73fc3905722
            {
                Console.Write(text[i]);
            }
           
        }
    }
}