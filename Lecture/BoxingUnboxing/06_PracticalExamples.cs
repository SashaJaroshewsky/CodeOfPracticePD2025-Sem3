using System;
using System.Numerics;

namespace BoxingUnboxingLessons
{
    /// <summary>
    /// Практичні приклади
    /// 
    /// Розглянемо реальні ситуації та пастки, в які можна потрапити.
    /// </summary>
    public class PracticalExamples
    {
        public static void Demo()
        {
            Console.WriteLine("=== Урок 6: Практичні приклади ===\n");

            // Приклад 1: Зміна упакованого значення
            Console.WriteLine("1. Чому не можна змінити упаковане значення?");
            int original = 10;
            object boxed = original;

            // Ця зміна НЕ впливає на boxed!
            original = 20;
            Console.WriteLine($"   original: {original}");
            Console.WriteLine($"   boxed: {boxed}");
            Console.WriteLine("   Це різні копії!\n");

            // Приклад 2: Nullable типи
            Console.WriteLine("2. Nullable типи і boxing:");
            int? nullableInt = 42;
            object boxedNullable = nullableInt; // Boxing
            Console.WriteLine($"   Nullable: {nullableInt}");
            Console.WriteLine($"   Boxed: {boxedNullable}");

            // Null також можна "упакувати"
            int? nullValue = null;
            object boxedNull = nullValue; // boxedNull буде null
            Console.WriteLine($"   Null упакований: {boxedNull == null}\n");

            // Приклад 3: Порівняння упакованих значень
            Console.WriteLine("3. Порівняння упакованих значень:");
            int num1 = 100;
            int num2 = 100;
            object box1 = num1;
            object box2 = num2;

            // Порівнюються посилання, а не значення!
            Console.WriteLine($"   num1 == num2: {num1 == num2}"); // true
            Console.WriteLine($"   box1 == box2: {box1 == box2}"); // false! Різні об'єкти
            Console.WriteLine($"   box1.Equals(box2): {box1.Equals(box2)}"); // true
        }
    }
}