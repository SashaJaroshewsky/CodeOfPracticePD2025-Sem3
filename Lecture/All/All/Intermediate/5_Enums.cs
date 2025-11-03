using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 5. Enums — Перерахування
    /// 
    /// ТЕОРІЯ:
    /// Enum — набір іменованих констант (цілочисельних значень)
    /// 
    /// ПЕРЕВАГИ:
    /// - Читабельність коду (Days.Monday замість 1)
    /// - Безпека типів (не можна передати невірне значення)
    /// - IntelliSense підтримка
    /// 
    /// За замовчуванням значення: 0, 1, 2, 3...
    /// Можна задати власні значення
    /// </summary>
    public class Enums
    {
        // Простий enum
        public enum Days
        {
            Monday,    // 0
            Tuesday,   // 1
            Wednesday, // 2
            Thursday,  // 3
            Friday,    // 4
            Saturday,  // 5
            Sunday     // 6
        }

        // Enum з власними значеннями
        public enum Priority
        {
            Low = 1,
            Medium = 2,
            High = 3,
            Critical = 5
        }

        // Enum для статусів
        public enum OrderStatus
        {
            Pending = 0,
            Processing = 1,
            Shipped = 2,
            Delivered = 3,
            Cancelled = -1
        }

        public static void PrintDay(Days day)
        {
            Console.WriteLine($"Сьогодні: {day}");

            // Switch з enum
            switch (day)
            {
                case Days.Saturday:
                case Days.Sunday:
                    Console.WriteLine("Вихідний день! 🎉");
                    break;
                default:
                    Console.WriteLine("Робочий день 💼");
                    break;
            }
        }

        public static void DemonstrateEnums()
        {
            // Використання enum
            Days today = Days.Monday;
            PrintDay(today);

            // Отримання числового значення
            int dayNumber = (int)today;
            Console.WriteLine($"Номер дня: {dayNumber}");

            // Перетворення числа в enum
            Days day3 = (Days)3;
            Console.WriteLine($"День 3: {day3}");  // Thursday

            // Перетворення рядка в enum
            Days parsed = (Days)Enum.Parse(typeof(Days), "Friday");
            Console.WriteLine($"Спарсений день: {parsed}");

            // Priority enum
            Priority taskPriority = Priority.High;
            Console.WriteLine($"\nПріоритет завдання: {taskPriority} ({(int)taskPriority})");

            if (taskPriority == Priority.Critical)
            {
                Console.WriteLine("ТЕРМІНОВЕ завдання!");
            }

            // Отримання всіх значень enum
            Console.WriteLine("\nВсі дні тижня:");
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }

            // OrderStatus
            OrderStatus status = OrderStatus.Processing;
            Console.WriteLine($"\nСтатус замовлення: {status}");
        }
    }
}
