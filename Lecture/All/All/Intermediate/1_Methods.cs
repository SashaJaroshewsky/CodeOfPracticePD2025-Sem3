using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 1. Methods — Методи (функції)
    /// 
    /// ТЕОРІЯ:
    /// Метод — блок коду, який виконує певну задачу
    /// 
    /// СТРУКТУРА:
    /// модифікатор тип_повернення Ім'я(параметри)
    /// {
    ///     // тіло методу
    ///     return значення;
    /// }
    /// 
    /// void — метод нічого не повертає
    /// return — повертає значення з методу
    /// 
    /// ПАРАМЕТРИ:
    /// - Вхідні дані для методу
    /// - Можуть бути будь-якого типу
    /// - Можна передавати кілька параметрів
    /// </summary>
    public class Methods
    {
        // Метод без параметрів, без повернення
        public static void SayHello()
        {
            Console.WriteLine("Привіт!");
        }

        // Метод з параметрами, без повернення
        public static void GreetUser(string name, int age)
        {
            Console.WriteLine($"Привіт, {name}! Тобі {age} років.");
        }

        // Метод з поверненням значення
        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;  // Повертаємо результат
        }

        // Метод з поверненням bool
        public static bool IsAdult(int age)
        {
            return age >= 18;  // Повертає true або false
        }

        // Метод з кількома return
        public static string GetGrade(int score)
        {
            if (score >= 90) return "A";
            if (score >= 80) return "B";
            if (score >= 70) return "C";
            if (score >= 60) return "D";
            return "F";
        }

        // Expression-bodied метод (короткий синтаксис)
        public static int Square(int x) => x * x;
        public static bool IsEven(int n) => n % 2 == 0;

        public static void DemonstrateMethods()
        {
            // Виклик методів
            SayHello();

            GreetUser("Марія", 20);

            int sum = Add(5, 3);
            Console.WriteLine($"5 + 3 = {sum}");

            bool adult = IsAdult(25);
            Console.WriteLine($"Чи повнолітній (25 років)? {adult}");

            string grade = GetGrade(85);
            Console.WriteLine($"Оцінка за 85%: {grade}");

            int squared = Square(7);
            Console.WriteLine($"7² = {squared}");
        }
    }
}
