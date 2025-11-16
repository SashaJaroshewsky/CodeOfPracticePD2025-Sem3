using System;

namespace BoxingUnboxingLessons
{
    /// <summary>
    /// Що таке Boxing (Упакування)?
    /// 
    /// Boxing - це процес перетворення типу значення (value type) 
    /// в тип посилання (reference type), а саме в object.
    /// 
    /// Під час boxing відбувається:
    /// 1. Виділення пам'яті в heap (купі)
    /// 2. Копіювання значення зі stack в heap
    /// 3. Створення посилання на об'єкт в heap
    /// </summary>
    public class WhatIsBoxing
    {
        public static void Demo()
        {
            Console.WriteLine("=== Урок 1: Що таке Boxing? ===\n");

            // Value type - зберігається в stack (швидка пам'ять)
            int number = 42;
            Console.WriteLine($"Значення int: {number}");
            Console.WriteLine($"Тип: {number.GetType()}");

            // Boxing - перетворення int в object
            // Тепер значення копіюється в heap (повільніша пам'ять)
            object boxedNumber = number;
            Console.WriteLine($"\nПісля boxing:");
            Console.WriteLine($"Значення object: {boxedNumber}");
            Console.WriteLine($"Тип: {boxedNumber.GetType()}");

            // Важливо: boxedNumber та number - це різні копії!
            number = 100;
            Console.WriteLine($"\nЗмінили оригінальний int: {number}");
            Console.WriteLine($"Boxing залишився незмінним: {boxedNumber}");
        }
    }
}