using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 10. StaticMembers — Статичні члени класу
    /// 
    /// ТЕОРІЯ:
    /// static — належить КЛАСУ, а не об'єкту
    /// 
    /// СТАТИЧНІ ЧЛЕНИ:
    /// - Поля — спільні для всіх об'єктів
    /// - Методи — можна викликати без створення об'єкта
    /// - Класи — не можна створити екземпляр
    /// 
    /// ДОСТУП: ІмяКласу.ІмяЧлена
    /// 
    /// ПРИКЛАДИ: Math.PI, Console.WriteLine(), Convert.ToInt32()
    /// 
    /// КОЛИ ВИКОРИСТОВУВАТИ:
    /// - Утилітні методи
    /// - Константи
    /// - Лічильники об'єктів
    /// - Фабричні методи
    /// </summary>
    public class StaticMembers
    {
        // Статичне поле — спільне для всіх об'єктів
        private static int objectCount = 0;

        // Звичайне (instance) поле — для кожного об'єкта своє
        private int id;

        // Конструктор
        public StaticMembers()
        {
            objectCount++;  // Збільшуємо лічильник при створенні об'єкта
            id = objectCount;
        }

        // Статичний метод — можна викликати без створення об'єкта
        public static int GetObjectCount()
        {
            return objectCount;
        }

        // Звичайний метод — потрібен об'єкт
        public void ShowId()
        {
            Console.WriteLine($"ID об'єкта: {id}");
            Console.WriteLine($"Всього об'єктів: {objectCount}");
        }

        // Статичний клас з утилітними методами
        public static class Calculator
        {
            // Статичні константи
            public const double PI = 3.14159265359;

            // Статичні методи
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static double CircleArea(double radius)
            {
                return PI * radius * radius;
            }

            public static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        }

        // Клас для демонстрації
        public class Temperature
        {
            // Instance поля
            public double Celsius { get; set; }

            // Конструктор
            public Temperature(double celsius)
            {
                Celsius = celsius;
            }

            // Статичний метод конвертації
            public static double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            public static double FahrenheitToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }

            // Instance метод
            public double ToFahrenheit()
            {
                return CelsiusToFahrenheit(Celsius);
            }
        }

        public static void DemonstrateStatic()
        {
            Console.WriteLine("=== СТАТИЧНІ vs ЗВИЧАЙНІ ЧЛЕНИ ===");

            // Статичний метод викликається через клас
            Console.WriteLine($"Об'єктів створено: {StaticMembers.GetObjectCount()}");

            // Створюємо об'єкти
            StaticMembers obj1 = new StaticMembers();
            obj1.ShowId();

            StaticMembers obj2 = new StaticMembers();
            obj2.ShowId();

            StaticMembers obj3 = new StaticMembers();
            obj3.ShowId();

            Console.WriteLine($"\nВсього: {StaticMembers.GetObjectCount()} об'єктів");

            // Використання статичного класу Calculator
            Console.WriteLine("\n=== СТАТИЧНИЙ КЛАС Calculator ===");
            int sum = Calculator.Add(10, 20);
            Console.WriteLine($"10 + 20 = {sum}");

            double area = Calculator.CircleArea(5);
            Console.WriteLine($"Площа кола (r=5): {area:F2}");

            bool even = Calculator.IsEven(42);
            Console.WriteLine($"42 парне? {even}");

            // Temperature з статичними методами
            Console.WriteLine("\n=== Temperature ===");

            // Статичний метод — без об'єкта
            double fahrenheit = Temperature.CelsiusToFahrenheit(25);
            Console.WriteLine($"25°C = {fahrenheit:F1}°F");

            // Instance метод — потрібен об'єкт
            Temperature temp = new Temperature(30);
            Console.WriteLine($"30°C = {temp.ToFahrenheit():F1}°F");

            // Приклади з бібліотеки .NET
            Console.WriteLine("\n=== ПРИКЛАДИ З .NET ===");
            Console.WriteLine($"Math.PI = {Math.PI}");
            Console.WriteLine($"Math.Sqrt(16) = {Math.Sqrt(16)}");
            Console.WriteLine($"Convert.ToInt32(\"42\") = {Convert.ToInt32("42")}");
        }
    }
}
