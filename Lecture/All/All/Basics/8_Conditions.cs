using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 8. Conditions — Умовні оператори
    /// 
    /// ТЕОРІЯ:
    /// if — виконує блок коду, якщо умова true
    /// else if — перевіряє іншу умову
    /// else — виконується, якщо всі умови false
    /// 
    /// ТЕРНАРНИЙ ОПЕРАТОР: умова ? значення1 : значення2
    /// 
    /// SWITCH — вибір з кількох варіантів (порівняння значень)
    /// </summary>
    public class Conditions
    {
        public static void DemonstrateConditions()
        {
            int score = 85;

            // IF-ELSE IF-ELSE
            if (score >= 90)
            {
                Console.WriteLine("Оцінка: Відмінно (A)");
            }
            else if (score >= 75)
            {
                Console.WriteLine("Оцінка: Добре (B)");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Оцінка: Задовільно (C)");
            }
            else
            {
                Console.WriteLine("Оцінка: Незадовільно (F)");
            }

            // ТЕРНАРНИЙ ОПЕРАТОР (короткий if-else)
            string result = score >= 60 ? "Здав" : "Не здав";
            Console.WriteLine($"Результат: {result}");

            // ВКЛАДЕНІ УМОВИ
            bool isStudent = true;
            if (isStudent)
            {
                if (score >= 90)
                    Console.WriteLine("Студент отримує стипендію!");
            }

            // SWITCH-CASE
            int dayNumber = 3;
            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Понеділок";
                    break;
                case 2:
                    dayName = "Вівторок";
                    break;
                case 3:
                    dayName = "Середа";
                    break;
                case 4:
                    dayName = "Четвер";
                    break;
                case 5:
                    dayName = "П'ятниця";
                    break;
                case 6:
                case 7:  // Можна об'єднувати випадки
                    dayName = "Вихідний";
                    break;
                default:
                    dayName = "Невірний номер дня";
                    break;
            }

            Console.WriteLine($"День {dayNumber}: {dayName}");
        }
    }
}
