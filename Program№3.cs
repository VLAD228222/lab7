using System;

namespace Lan7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 30;
            int[] numbers = new int[size];
            Random rnd = new Random();

            Console.WriteLine("Автор проєкту: Дейко Влад\n");

            // Автоматичне заповнення масиву випадковими числами від -50 до 50
            Console.WriteLine("Згенерований масив:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(-50, 51); // від -50 до 50 включно
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            // Пошук максимального серед від’ємних чисел
            int? maxNegative = null;
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    if (maxNegative == null || number > maxNegative)
                    {
                        maxNegative = number;
                    }
                }
            }

            if (maxNegative != null)
            {
                Console.WriteLine($"\nМаксимальний серед від’ємних елементів: {maxNegative}");
            }
            else
            {
                Console.WriteLine("\nУ масиві немає від’ємних елементів.");
            }

            Console.ReadLine();
        }
    }
}
