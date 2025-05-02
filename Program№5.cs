using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Автор проєкту:Дейко Влад\n");

            // Введення рядка з клавіатури
            Console.Write("Введіть слово: ");
            string input = Console.ReadLine();

            // Вивід у зворотному порядку
            Console.Write("Слово у зворотному порядку: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            // Вивід символів з * після кожної літери
            Console.Write("Слово з * після кожної літери: ");
            foreach (char c in input)
            {
                Console.Write(c + "*");
            }

            Console.ReadLine();
        }
    }
}
