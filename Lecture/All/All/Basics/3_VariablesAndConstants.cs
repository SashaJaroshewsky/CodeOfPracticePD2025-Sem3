using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 3. VariablesAndConstants — Змінні та константи
    /// 
    /// ТЕОРІЯ:
    /// ЗМІННА — поіменована область пам'яті, значення якої можна змінювати
    /// КОНСТАНТА — значення, яке не можна змінити після ініціалізації (const)
    /// 
    /// ПРАВИЛА ІМЕНУВАННЯ:
    /// - Починається з літери або підкреслення (_)
    /// - Може містити літери, цифри, підкреслення
    /// - Регістрозалежні: name та Name — різні змінні
    /// - Не можна використовувати ключові слова (int, class, if тощо)
    /// 
    /// СТИЛІ ІМЕНУВАННЯ:
    /// - camelCase для змінних: myVariable, firstName
    /// - PascalCase для методів/класів: MyMethod, MyClass
    /// - UPPER_CASE для констант: MAX_VALUE
    /// </summary>
    public class VariablesAndConstants
    {
        // Константа — значення не змінюється
        public const double PI = 3.14159;
        public const int MAX_STUDENTS = 30;

        public static void DemonstrateVariables()
        {
            // Оголошення та ініціалізація змінної
            int studentCount = 25;

            // Можна оголосити без ініціалізації
            string studentName;
            studentName = "Олена";

            // Ключове слово var — компілятор сам визначає тип
            var autoType = 100;  // Це int
            var text = "Текст";  // Це string

            // Зміна значення змінної
            studentCount = 28;
            studentCount = studentCount + 2; // Тепер 30

            // Використання константи
            double circleArea = PI * 5 * 5;

            //PI = 3.14; // ПОМИЛКА! Константу не можна змінити

            Console.WriteLine($"Студентів: {studentCount}, Площа: {circleArea}");
        }
    }
}
