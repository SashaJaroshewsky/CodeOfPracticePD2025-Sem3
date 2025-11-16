using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxingLessons
{
    /// <summary>
    /// Як уникнути Boxing/Unboxing?
    /// 
    /// Використовуємо generic (узагальнені типи), щоб уникнути boxing
    /// та зробити код швидшим і безпечнішим.
    /// </summary>
    public class HowToAvoid
    {
        public static void Demo()
        {
            Console.WriteLine("=== Урок 5: Як уникнути Boxing? ===\n");

            // ❌ ПОГАНО: ArrayList викликає boxing
            Console.WriteLine("❌ ArrayList (з boxing):");
            ArrayList oldList = new ArrayList();
            oldList.Add(1);    // Boxing
            oldList.Add(2);    // Boxing
            oldList.Add(3);    // Boxing
            int sum1 = 0;
            foreach (object item in oldList)
            {
                sum1 += (int)item; // Unboxing на кожній ітерації
            }
            Console.WriteLine($"   Сума: {sum1}");

            // ✓ ДОБРЕ: List<T> без boxing
            Console.WriteLine("\n✓ List<int> (без boxing):");
            List<int> newList = new List<int>();
            newList.Add(1);    // Без boxing
            newList.Add(2);    // Без boxing
            newList.Add(3);    // Без boxing
            int sum2 = 0;
            foreach (int item in newList)
            {
                sum2 += item; // Без unboxing
            }
            Console.WriteLine($"   Сума: {sum2}");

            // Generic методи - універсальне рішення
            Console.WriteLine("\n✓ Generic методи:");
            PrintValue(42);      // Без boxing для int
            PrintValue("Hello"); // Працює і для string
            PrintValue(3.14);    // Без boxing для double
        }

        // Generic метод - працює з будь-яким типом без boxing
        static void PrintValue<T>(T value)
        {
            Console.WriteLine($"   Значення: {value}, Тип: {typeof(T).Name}");
        }
    }
}