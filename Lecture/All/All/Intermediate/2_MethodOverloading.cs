using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 2. MethodOverloading — Перевантаження методів
    /// 
    /// ТЕОРІЯ:
    /// Кілька методів з ОДНИМ ім'ям, але РІЗНИМИ параметрами
    /// 
    /// ВІДРІЗНЯЮТЬСЯ ЗА:
    /// - Кількістю параметрів
    /// - Типами параметрів
    /// - Порядком параметрів
    /// 
    /// НЕ ВІДРІЗНЯЮТЬСЯ за типом повернення!
    /// 
    /// ПЕРЕВАГИ:
    /// - Зручність використання
    /// - Одне ім'я для схожих операцій
    /// - Гнучкість виклику
    /// </summary>
    public class MethodOverloading
    {
        // Перевантаження за кількістю параметрів
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        // Перевантаження за типом параметрів
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Перевантаження методу Print
        public static void Print(string message)
        {
            Console.WriteLine($"String: {message}");
        }

        public static void Print(int number)
        {
            Console.WriteLine($"Integer: {number}");
        }

        public static void Print(double number)
        {
            Console.WriteLine($"Double: {number}");
        }

        // Перевантаження за порядком параметрів
        public static void Display(string text, int number)
        {
            Console.WriteLine($"Text: {text}, Number: {number}");
        }

        public static void Display(int number, string text)
        {
            Console.WriteLine($"Number: {number}, Text: {text}");
        }

        public static void DemonstrateOverloading()
        {
            // Компілятор сам обирає потрібний метод
            Console.WriteLine(Multiply(3, 4));        // 12 (2 параметри int)
            Console.WriteLine(Multiply(2, 3, 4));     // 24 (3 параметри int)
            Console.WriteLine(Multiply(2.5, 4.0));    // 10.0 (2 параметри double)

            Print("Привіт");   // String version
            Print(42);         // Integer version
            Print(3.14);       // Double version

            Display("ABC", 123);   // text, number
            Display(456, "XYZ");   // number, text
        }
    }
}
