using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 10. Arrays — Масиви
    /// 
    /// ТЕОРІЯ:
    /// Масив — колекція елементів ОДНОГО типу фіксованого розміру
    /// Індексація починається з 0: arr[0] — перший елемент
    /// 
    /// ОДНОМІРНИЙ МАСИВ: int[] numbers = new int[5];
    /// БАГАТОМІРНИЙ МАСИВ: int[,] matrix = new int[3, 4];
    /// ЗУБЧАСТИЙ МАСИВ (масив масивів): int[][] jagged;
    /// 
    /// ВЛАСТИВОСТІ:
    /// - Length — загальна кількість елементів
    /// - GetLength(dimension) — розмір конкретного виміру
    /// </summary>
    public class Arrays
    {
        public static void DemonstrateArrays()
        {
            // ОДНОМІРНИЙ МАСИВ
            Console.WriteLine("=== ОДНОМІРНІ МАСИВИ ===");

            // Спосіб 1: вказуємо розмір
            int[] numbers = new int[5];  // [0, 0, 0, 0, 0]
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            // Спосіб 2: ініціалізація зі значеннями
            string[] names = { "Іван", "Марія", "Петро" };

            // Спосіб 3: з використанням new
            double[] prices = new double[] { 99.99, 149.50, 79.99 };

            // Доступ до елементів
            Console.WriteLine($"Перше ім'я: {names[0]}");
            Console.WriteLine($"Останнє ім'я: {names[names.Length - 1]}");

            // Перебір масиву
            Console.WriteLine("\nВсі імена:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }

            // Foreach для масивів
            Console.WriteLine("\nЦіни:");
            foreach (double price in prices)
            {
                Console.WriteLine($"{price} грн");
            }

            // ДВОВИМІРНИЙ МАСИВ (МАТРИЦЯ)
            Console.WriteLine("\n=== ДВОВИМІРНІ МАСИВИ ===");

            int[,] matrix = new int[3, 4];  // 3 рядки, 4 стовпці
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 2] = 5;

            // Ініціалізація матриці
            int[,] table = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Таблиця 3x3:");
            for (int row = 0; row < table.GetLength(0); row++)  // Кількість рядків
            {
                for (int col = 0; col < table.GetLength(1); col++)  // Кількість стовпців
                {
                    Console.Write($"{table[row, col]}\t");
                }
                Console.WriteLine();
            }

            // ЗУБЧАСТИЙ МАСИВ (масив масивів)
            Console.WriteLine("\n=== ЗУБЧАСТІ МАСИВИ ===");

            int[][] jagged = new int[3][];  // 3 рядки
            jagged[0] = new int[] { 1, 2 };       // Перший рядок: 2 елементи
            jagged[1] = new int[] { 3, 4, 5 };    // Другий рядок: 3 елементи
            jagged[2] = new int[] { 6 };          // Третій рядок: 1 елемент

            Console.WriteLine("Зубчастий масив:");
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write($"Рядок {i}: ");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }

            // КОРИСНІ МЕТОДИ Array
            int[] nums = { 5, 2, 8, 1, 9 };
            Console.WriteLine("\n=== МЕТОДИ ARRAY ===");
            Console.WriteLine($"Оригінальний: {string.Join(", ", nums)}");

            Array.Sort(nums);  // Сортування
            Console.WriteLine($"Відсортований: {string.Join(", ", nums)}");

            Array.Reverse(nums);  // Реверс
            Console.WriteLine($"Реверс: {string.Join(", ", nums)}");

            int index = Array.IndexOf(nums, 8);  // Пошук індексу
            Console.WriteLine($"Індекс числа 8: {index}");
        }
    }
}
