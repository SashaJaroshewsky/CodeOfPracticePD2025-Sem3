using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 4. Collections — Колекції
    /// 
    /// ТЕОРІЯ:
    /// Колекції — "динамічні" структури даних (на відміну від масивів)
    /// 
    /// List<T> — "динамічний" масив (можна додавати/видаляти елементи)
    /// Dictionary<TKey, TValue> — пари ключ-значення (асоціативний масив)
    /// Queue<T> — черга (FIFO — First In First Out)
    /// Stack<T> — стек (LIFO — Last In First Out)
    /// 
    /// Потребує: using System.Collections.Generic;
    /// </summary>
    public class Collections
    {
        public static void DemonstrateCollections()
        {
            // LIST — динамічний масив
            Console.WriteLine("=== LIST ===");
            List<string> fruits = new List<string>();

            // Додавання елементів
            fruits.Add("яблуко");
            fruits.Add("банан");
            fruits.Add("апельсин");

            Console.WriteLine($"Кількість фруктів: {fruits.Count}");
            Console.WriteLine($"Перший фрукт: {fruits[0]}");

            // Вставка на позицію
            fruits.Insert(1, "груша");  // Вставляємо на позицію 1

            // Видалення
            fruits.Remove("банан");     // Видаляємо за значенням
            fruits.RemoveAt(0);         // Видаляємо за індексом

            // Перебір
            Console.WriteLine("Фрукти:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            // Пошук
            bool hasBanana = fruits.Contains("банан");
            Console.WriteLine($"Є банан? {hasBanana}");

            // DICTIONARY — словник (ключ-значення)
            Console.WriteLine("\n=== DICTIONARY ===");
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Додавання
            ages["Іван"] = 25;
            ages["Марія"] = 22;
            ages.Add("Петро", 30);

            // Доступ до значень
            Console.WriteLine($"Вік Івана: {ages["Іван"]}");

            // Перевірка наявності ключа
            if (ages.ContainsKey("Марія"))
            {
                Console.WriteLine($"Вік Марії: {ages["Марія"]}");
            }

            // Перебір
            Console.WriteLine("Всі віки:");
            foreach (var pair in ages)  // KeyValuePair<string, int>
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} років");
            }

            // Видалення
            ages.Remove("Петро");

            // QUEUE — черга (FIFO)
            Console.WriteLine("\n=== QUEUE ===");
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("перший");    // Додаємо в кінець
            queue.Enqueue("другий");
            queue.Enqueue("третій");

            Console.WriteLine($"Перший в черзі: {queue.Peek()}");  // Дивимося без видалення

            string first = queue.Dequeue();  // Забираємо перший
            Console.WriteLine($"Обслужено: {first}");
            Console.WriteLine($"Тепер перший: {queue.Peek()}");

            // STACK — стек (LIFO)
            Console.WriteLine("\n=== STACK ===");
            Stack<int> stack = new Stack<int>();

            stack.Push(1);  // Кладемо на вершину
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Вершина стеку: {stack.Peek()}");  // 3

            int top = stack.Pop();  // Забираємо з вершини
            Console.WriteLine($"Взято: {top}");
            Console.WriteLine($"Нова вершина: {stack.Peek()}");  // 2
        }
    }
}
