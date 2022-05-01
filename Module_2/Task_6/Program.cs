
using System;

namespace Task_6
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст");
            string? str = Console.ReadLine();
            char[]? text = str?.ToCharArray();

            if(text == null)
            {
                Console.WriteLine("Текст не введен");
                return;
            }

                int size = 0;

            for(int i = 0; i < text.Length; i++)
            {

                if (char.IsLetterOrDigit(text[i]) && size == 0)
                {
                    if(char.IsLower(text[i]) && !char.IsDigit(text[i]))
                    {
                       text[i] = char.ToUpper(text[i]);
                    }
                    ++size;
                }
                else if (char.IsPunctuation(text[i]) && text[i] != ',')
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        if (char.IsLetterOrDigit(text[j]))
                        {
                            if (char.IsLetter(text[j]))
                            {
                                if (char.IsLower(text[j]))
                                {
                                    text[j] = char.ToUpper(text[j]);
                                    i = j;
                                    break;
                                }
                                else if (char.IsDigit(text[j]))
                                {
                                    i = j;
                                    break;
                                }
                            }
                        }

                        i = j;
                    }
                }
            }

            foreach(char c in text)
            {
                Console.Write(c);
            }
        }
    }
}