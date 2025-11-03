using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 7. Strings — Робота з рядками
    /// 
    /// ТЕОРІЯ:
    /// string — незмінний тип (immutable): методи створюють НОВІ рядки
    /// 
    /// ОСНОВНІ МЕТОДИ:
    /// - Length — довжина рядка
    /// - ToUpper(), ToLower() — зміна регістру
    /// - Trim() — видалення пробілів з початку і кінця
    /// - Substring(start, length) — підрядок
    /// - Contains(text) — чи містить текст
    /// - Replace(old, new) — заміна
    /// - Split(separator) — розділення на масив
    /// 
    /// ІНТЕРПОЛЯЦІЯ: $"текст {змінна}"
    /// КОНКАТЕНАЦІЯ: string.Concat() або оператор +
    /// </summary>
    public class Strings
    {
        public static void DemonstrateStrings()
        {
            string text = "  Програмування на C#  ";

            // ВЛАСТИВОСТІ
            int length = text.Length;  // 24 (з пробілами)
            Console.WriteLine($"Довжина: {length}");

            // МЕТОДИ ЗМІНИ РЕГІСТРУ
            string upper = text.ToUpper();  // "  ПРОГРАМУВАННЯ НА C#  "
            string lower = text.ToLower();  // "  програмування на c#  "

            // ВИДАЛЕННЯ ПРОБІЛІВ
            string trimmed = text.Trim();   // "Програмування на C#"
            Console.WriteLine($"Обрізаний: '{trimmed}'");

            // ПІДРЯДОК
            string sub = trimmed.Substring(0, 13);  // "Програмування"
            Console.WriteLine($"Підрядок: {sub}");

            // ПОШУК ТА ПЕРЕВІРКА
            bool contains = trimmed.Contains("C#");  // true
            bool starts = trimmed.StartsWith("Prog"); // true (англійський)
            bool ends = trimmed.EndsWith("#");        // true

            // ЗАМІНА
            string replaced = trimmed.Replace("C#", "Java");
            Console.WriteLine($"Заміна: {replaced}");

            // РОЗДІЛЕННЯ
            string fruits = "яблуко,груша,банан";
            string[] arr = fruits.Split(',');  // ["яблуко", "груша", "банан"]
            Console.WriteLine($"Перший фрукт: {arr[0]}");

            // ОБ'ЄДНАННЯ
            string joined = string.Join(" | ", arr);  // "яблуко | груша | банан"
            Console.WriteLine($"Об'єднано: {joined}");

            // ІНТЕРПОЛЯЦІЯ
            string name = "Іван";
            int age = 25;
            string message = $"{name} має {age} років.";
            Console.WriteLine(message);

            // ДОСТУП ДО СИМВОЛІВ
            char firstChar = trimmed[0];  // 'П'
            Console.WriteLine($"Перший символ: {firstChar}");
        }
    }
}
