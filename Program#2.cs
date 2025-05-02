using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] numbers = new int[size];

            Console.WriteLine("Автор проєкту:Дейко Влад\n");

            // Введення масиву
            for (int i = 0; i < size; i++)
            {
                bool isValid;
                do
                {
                    Console.Write($"Введіть елемент [{i + 1}]: ");
                    string input = Console.ReadLine();
                    isValid = int.TryParse(input, out numbers[i]);
                    if (!isValid)
                        Console.WriteLine("Невірне значення! Введіть ціле число.");
                }
                while (!isValid);
            }

            // Вибір дії: сума або добуток
            Console.Write("\nВиберіть операцію (1 - сума, 2 - добуток): ");
            string choice = Console.ReadLine();

            // Пошук індексів мінімального та максимального елементів
            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < size; i++)
            {
                if (numbers[i] < numbers[minIndex]) minIndex = i;
                if (numbers[i] > numbers[maxIndex]) maxIndex = i;
            }

            int start = Math.Min(minIndex, maxIndex) + 1;
            int end = Math.Max(minIndex, maxIndex) - 1;

            if (start > end)
            {
                Console.WriteLine("Немає елементів між мінімальним і максимальним.");
                return;
            }

            if (choice == "1")
            {
                int sum = 0;
                for (int i = start; i <= end; i++)
                    sum += numbers[i];
                Console.WriteLine($"Сума елементів між мінімальним і максимальним: {sum}");
            }
            else if (choice == "2")
            {
                int product = 1;
                for (int i = start; i <= end; i++)
                    product *= numbers[i];
                Console.WriteLine($"Добуток елементів між мінімальним і максимальним: {product}");
            }
            else
            {
                Console.WriteLine("Невірний вибір операції.");
            }

            Console.ReadLine();
        }
    }
}
