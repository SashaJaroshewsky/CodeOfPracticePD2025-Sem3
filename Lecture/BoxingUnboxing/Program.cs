using System;

namespace BoxingUnboxingLessons
{
    /// <summary>
    /// Головний клас для запуску всіх уроків
    /// 
    /// Запускайте кожен урок окремо, щоб краще зрозуміти матеріал.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║  УРОКИ: BOXING / UNBOXING в C#            ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();

            // Запуск всіх уроків по черзі
            RunLesson("Урок 1", WhatIsBoxing.Demo);
            RunLesson("Урок 2", WhatIsUnboxing.Demo);
            RunLesson("Урок 3", WhyItMatters.Demo);
            RunLesson("Урок 4", CommonScenarios.Demo);
            RunLesson("Урок 5", HowToAvoid.Demo);
            RunLesson("Урок 6", PracticalExamples.Demo);

            // Підсумок
            Console.WriteLine("\n╔════════════════════════════════════════════╗");
            Console.WriteLine("║  ПІДСУМОК                                 ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("\n✓ Boxing - перетворення value type -> object");
            Console.WriteLine("✓ Unboxing - перетворення object -> value type");
            Console.WriteLine("✓ Boxing впливає на продуктивність і пам'ять");
            Console.WriteLine("✓ Використовуйте generic (List<T>) замість старих колекцій");
            Console.WriteLine("✓ Будьте обережні при порівнянні упакованих значень");

            Console.WriteLine("\n\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Допоміжний метод для запуску уроку з форматуванням
        /// </summary>
        static void RunLesson(string lessonName, Action lessonMethod)
        {
            Console.WriteLine();
            lessonMethod();
            Console.WriteLine("\n" + new string('─', 50));
            Console.WriteLine("Натисніть будь-яку клавішу для наступного уроку...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}