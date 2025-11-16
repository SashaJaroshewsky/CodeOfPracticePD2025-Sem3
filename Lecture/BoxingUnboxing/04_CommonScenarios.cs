using System;
using System.Collections;

namespace BoxingUnboxingLessons
{
    /// <summary>
    /// Типові ситуації, де відбувається Boxing
    /// 
    /// Boxing може відбуватися непомітно для програміста.
    /// Важливо знати, де це відбувається, щоб уникати проблем з продуктивністю.
    /// </summary>
    public class CommonScenarios
    {
        public static void Demo()
        {
            Console.WriteLine("=== Урок 4: Де відбувається Boxing? ===\n");

            // Сценарій 1: Колекції (до generic)
            Console.WriteLine("1. ArrayList (старі колекції без generic):");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(42);        // ❌ Boxing int -> object
            arrayList.Add(3.14);      // ❌ Boxing double -> object
            int value1 = (int)arrayList[0]; // ❌ Unboxing object -> int
            Console.WriteLine($"   Значення: {value1} (з boxing/unboxing)");

            // Сценарій 2: String.Format та інтерполяція
            Console.WriteLine("\n2. Форматування рядків:");
            int age = 25;
            string text1 = String.Format("Вік: {0}", age); // ❌ Boxing
            string text2 = $"Вік: {age}"; // ❌ Також boxing!
            Console.WriteLine($"   {text1}");

            // Сценарій 3: Передача в метод, що приймає object
            Console.WriteLine("\n3. Методи з параметром object:");
            PrintAsObject(123); // ❌ Boxing

            // Сценарій 4: Інтерфейси
            Console.WriteLine("\n4. Приведення до інтерфейсу:");
            int number = 42;
            IComparable comparable = number; // ❌ Boxing
            Console.WriteLine($"   Порівняння: {comparable.CompareTo(40)}");
        }

        // Метод, що приймає object - викликає boxing для value types
        static void PrintAsObject(object obj)
        {
            Console.WriteLine($"   Отримано: {obj}");
        }
    }
}