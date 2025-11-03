using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 9. Loops — Цикли
    /// 
    /// ТЕОРІЯ:
    /// for — коли відома кількість ітерацій
    /// while — виконується, поки умова true (перевірка ДО виконання)
    /// do-while — виконується мінімум 1 раз (перевірка ПІСЛЯ виконання)
    /// foreach — для перебору колекцій/масивів
    /// 
    /// КЕРУВАННЯ ЦИКЛАМИ:
    /// break — вихід з циклу
    /// continue — перехід до наступної ітерації
    /// </summary>
    public class Loops
    {
        public static void DemonstrateLoops()
        {
            // FOR — найчастіше використовується
            Console.WriteLine("Цикл for:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Ітерація {i}");
            }

            // WHILE — коли не знаємо кількість ітерацій
            Console.WriteLine("\nЦикл while:");
            int count = 1;
            while (count <= 3)
            {
                Console.WriteLine($"Count = {count}");
                count++;
            }

            // DO-WHILE — виконається мінімум 1 раз
            Console.WriteLine("\nЦикл do-while:");
            int num = 10;
            do
            {
                Console.WriteLine($"Число: {num}");
                num--;
            } while (num > 8);

            // FOREACH — для масивів та колекцій
            Console.WriteLine("\nЦикл foreach:");
            string[] fruits = { "яблуко", "банан", "апельсин" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Фрукт: {fruit}");
            }

            // BREAK — вихід з циклу
            Console.WriteLine("\nВикористання break:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Зупинка на 5!");
                    break;  // Виходимо з циклу
                }
                Console.WriteLine(i);
            }

            // CONTINUE — пропуск ітерації
            Console.WriteLine("\nВикористання continue:");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;  // Пропускаємо 3
                }
                Console.WriteLine(i);
            }

            // ВКЛАДЕНІ ЦИКЛИ
            Console.WriteLine("\nВкладені цикли (таблиця множення):");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();  // Новий рядок
            }
        }
    }
}
