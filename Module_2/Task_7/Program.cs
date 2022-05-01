
using System;

namespace Task_7
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string? str = Console.ReadLine();
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
                if(text[i] == word?[0])
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

            for (int i = 0; i < text?.Length; i++)
            {
                Console.Write(text[i]);
            }
           
        }
    }
}