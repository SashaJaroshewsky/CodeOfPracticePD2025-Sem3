using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 6. InputOutput — Введення та виведення
    /// 
    /// ТЕОРІЯ:
    /// Console.Write() — виведення без переходу на новий рядок
    /// Console.WriteLine() — виведення з переходом на новий рядок
    /// Console.ReadLine() — читання рядка від користувача
    /// Console.ReadKey() — читання одного символу
    /// 
    /// ФОРМАТУВАННЯ:
    /// - Інтерполяція: $"Текст {змінна}"
    /// - Конкатенація: "Текст " + змінна
    /// </summary>
    public class InputOutput
    {
        public static void DemonstrateIO()
        {
            // ВИВЕДЕННЯ
            Console.Write("Це текст без переходу. ");
            Console.WriteLine("А це з переходом на новий рядок.");

            // ІНТЕРПОЛЯЦІЯ РЯДКІВ (рекомендований спосіб)
            string name = "Марія";
            int age = 20;
            Console.WriteLine($"Мене звати {name}, мені {age} років.");

            // КОНКАТЕНАЦІЯ
            Console.WriteLine("Мене звати " + name + ", мені " + age + " років.");

            // ВВЕДЕННЯ ДАНИХ
            Console.Write("Введіть ваше ім'я: ");
            string userName = Console.ReadLine();  // Читає весь рядок

            Console.Write("Введіть ваш вік: ");
            string ageInput = Console.ReadLine();
            int userAge = int.Parse(ageInput);  // Перетворюємо в число

            Console.WriteLine($"\nПривіт, {userName}! Вам {userAge} років.");

            // ЧИТАННЯ ОДНОГО СИМВОЛУ
            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();  // Чекає натискання клавіші
        }
    }
}
