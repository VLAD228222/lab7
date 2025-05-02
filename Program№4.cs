using System;

namespace SearchValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Автор проєкту:Дейко Влад\n");

            // Введення розміру масиву 
            int size;
            while (true)
            {
                Console.Write("Введіть розмір масиву: ");
                if (int.TryParse(Console.ReadLine(), out size) && size > 0)
                    break;
                Console.WriteLine("Помилка. Введіть ціле додатне число.");
            }

            int[] array = new int[size];

            // Вибір способу заповнення масиву 
            string method;
            while (true)
            {
                Console.Write("Оберіть спосіб заповнення масиву (1 – вручну, 2 – випадкові значення): ");
                method = Console.ReadLine();
                if (method == "1" || method == "2")
                    break;
                Console.WriteLine("Помилка. Введіть 1 або 2.");
            }

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                if (method == "2")
                {
                    array[i] = rnd.Next(0, 21);
                }
                else
                {
                    while (true)
                    {
                        Console.Write($"Введіть елемент [{i + 1}]: ");
                        if (int.TryParse(Console.ReadLine(), out array[i]))
                            break;
                        Console.WriteLine("Помилка. Введіть ціле число.");
                    }
                }
            }

            // Введення шуканого значення
            int target;
            while (true)
            {
                Console.Write("\nВведіть значення для пошуку: ");
                if (int.TryParse(Console.ReadLine(), out target))
                    break;
                Console.WriteLine("Помилка. Введіть ціле число.");
            }

            // Пошук кількості входжень
            int count = 0;
            foreach (int number in array)
            {
                if (number == target)
                    count++;
            }

            // Виведення результату
            if (count > 0)
            {
                Console.WriteLine($"\nЗначення {target} зустрічається у масиві {count} раз(ів).");
            }
            else
            {
                Console.WriteLine($"\nЗначення {target} у масиві не знайдено.");
            }

            Console.ReadLine();
        }
    }
}
