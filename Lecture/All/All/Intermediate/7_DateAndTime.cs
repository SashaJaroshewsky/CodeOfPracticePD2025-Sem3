using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 7. DateAndTime — Робота з датою та часом
    /// 
    /// ТЕОРІЯ:
    /// DateTime — структура для роботи з датою і часом
    /// TimeSpan — структура для роботи з інтервалами часу
    /// 
    /// СТВОРЕННЯ DateTime:
    /// - DateTime.Now — поточні дата та час
    /// - DateTime.Today — поточна дата (час 00:00:00)
    /// - new DateTime(year, month, day, ...)
    /// 
    /// ФОРМАТУВАННЯ:
    /// - ToString(format) — форматований вивід
    /// - "d", "D", "t", "T", "yyyy-MM-dd" тощо
    /// </summary>
    public class DateAndTime
    {
        public static void DemonstrateDateTime()
        {
            // Поточна дата та час
            DateTime now = DateTime.Now;
            Console.WriteLine($"Зараз: {now}");

            DateTime today = DateTime.Today;
            Console.WriteLine($"Сьогодні: {today:d}");  // Тільки дата

            // Створення конкретної дати
            DateTime birthday = new DateTime(2000, 5, 15);
            Console.WriteLine($"День народження: {birthday:D}");  // Повний формат

            DateTime specificTime = new DateTime(2024, 12, 25, 10, 30, 0);
            Console.WriteLine($"Конкретний час: {specificTime}");

            // Компоненти DateTime
            Console.WriteLine($"\nКомпоненти:");
            Console.WriteLine($"Рік: {now.Year}");
            Console.WriteLine($"Місяць: {now.Month}");
            Console.WriteLine($"День: {now.Day}");
            Console.WriteLine($"Година: {now.Hour}");
            Console.WriteLine($"Хвилина: {now.Minute}");
            Console.WriteLine($"Секунда: {now.Second}");
            Console.WriteLine($"День тижня: {now.DayOfWeek}");
            Console.WriteLine($"День року: {now.DayOfYear}");

            // Додавання та віднімання
            Console.WriteLine($"\nОперації з датами:");
            DateTime tomorrow = now.AddDays(1);
            DateTime nextWeek = now.AddDays(7);
            DateTime nextMonth = now.AddMonths(1);
            DateTime nextYear = now.AddYears(1);

            Console.WriteLine($"Завтра: {tomorrow:d}");
            Console.WriteLine($"Через тиждень: {nextWeek:d}");
            Console.WriteLine($"Через місяць: {nextMonth:d}");

            // Порівняння дат
            Console.WriteLine($"\nПорівняння:");
            if (tomorrow > now)
            {
                Console.WriteLine("Завтра пізніше за сьогодні");
            }

            // TimeSpan — інтервал часу
            Console.WriteLine($"\n=== TIMESPAN ===");
            TimeSpan age = now - birthday;
            Console.WriteLine($"Вік: {age.Days} днів");
            Console.WriteLine($"Вік: {age.TotalDays:F0} повних днів");
            Console.WriteLine($"Вік: {age.Days / 365} років (приблизно)");

            // Створення TimeSpan
            TimeSpan duration = new TimeSpan(2, 30, 0);  // 2 години 30 хвилин
            Console.WriteLine($"Тривалість: {duration}");

            TimeSpan oneDay = TimeSpan.FromDays(1);
            TimeSpan oneHour = TimeSpan.FromHours(1);
            TimeSpan tenMinutes = TimeSpan.FromMinutes(10);

            DateTime eventEnd = now + duration;
            Console.WriteLine($"Подія закінчиться: {eventEnd:t}");

            // Форматування
            Console.WriteLine($"\n=== ФОРМАТУВАННЯ ===");
            Console.WriteLine($"Short date: {now:d}");         // 03.11.2025
            Console.WriteLine($"Long date: {now:D}");          // понеділок, 3 листопада 2025 р.
            Console.WriteLine($"Short time: {now:t}");         // 14:30
            Console.WriteLine($"Long time: {now:T}");          // 14:30:45
            Console.WriteLine($"Custom: {now:yyyy-MM-dd}");    // 2025-11-03
            Console.WriteLine($"Custom: {now:dd.MM.yyyy HH:mm}"); // 03.11.2025 14:30
        }
    }
}
