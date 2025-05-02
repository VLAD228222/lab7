using System;
using System.Linq;

namespace LAB7
{
    class Program
    {
        static void Main(string[] args)
        {
            string authorSurname = "Дейко Влад";
            Console.WriteLine($"Автор проєкту: {authorSurname}\n");

            // Ініціалізація масиву
            int[] numbers = { 5, 12, 7, 3, 18, 10 };

            // Перевірка правильності введення значень (у цьому випадку — просто перевірка на порожній масив)
            if (numbers.Length == 0)
            {
                Console.WriteLine("Масив порожній!");
                return;
            }

            // Обчислення середнього арифметичного
            double average = numbers.Average();
            Console.WriteLine($"Середнє арифметичне: {average:F2}");

            // Виведення елементів, більших за середнє
            Console.WriteLine("Елементи масиву, більші за середнє значення:");
            foreach (int number in numbers)
            {
                if (number > average)
                {
                    Console.WriteLine(number);
                }
            }

            Console.ReadLine(); 
        }
    }
}
