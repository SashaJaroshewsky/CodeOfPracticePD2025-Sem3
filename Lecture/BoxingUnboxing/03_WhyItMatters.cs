using System;
using System.Diagnostics;

namespace BoxingUnboxingLessons
{
    /// <summary>
    /// Чому Boxing/Unboxing важливий?
    /// 
    /// Boxing/Unboxing впливає на:
    /// - Продуктивність (швидкість роботи програми)
    /// - Використання пам'яті
    /// - Роботу збирача сміття (Garbage Collector)
    /// </summary>
    public class WhyItMatters
    {
        public static void Demo()
        {
            Console.WriteLine("=== Урок 3: Чому це важливо? ===\n");

            // Демонстрація впливу на продуктивність
            const int iterations = 1000000;

            // Тест 1: Без boxing (швидко)
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                int value = i; // Працюємо тільки зі stack
            }
            sw.Stop();
            Console.WriteLine($"Без boxing: {sw.ElapsedMilliseconds} мс");

            // Тест 2: З boxing (повільніше)
            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                object value = i; // Boxing на кожній ітерації!
            }
            sw.Stop();
            Console.WriteLine($"З boxing: {sw.ElapsedMilliseconds} мс");

            // Пояснення різниці
            Console.WriteLine("\n📝 Чому різниця?");
            Console.WriteLine("- Boxing створює об'єкти в heap");
            Console.WriteLine("- Heap повільніший за stack");
            Console.WriteLine("- Кожен boxing = виділення пам'яті + копіювання");
            Console.WriteLine("- Збирач сміття має прибирати ці об'єкти");
        }
    }
}