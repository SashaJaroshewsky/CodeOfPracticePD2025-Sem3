using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 5. TypeCasting — Перетворення типів
    /// 
    /// ТЕОРІЯ:
    /// НЕЯВНЕ (Implicit) — автоматичне, без втрати даних
    /// - Від меншого до більшого: int → long → float → double
    /// 
    /// ЯВНЕ (Explicit) — вручну, можлива втрата даних
    /// - Від більшого до меншого: double → int (відкидається дробова частина)
    /// - Синтаксис: (тип)значення
    /// 
    /// МЕТОДИ Convert та Parse:
    /// - Convert.ToInt32(), Convert.ToDouble() тощо
    /// - int.Parse(), double.Parse() — з рядків
    /// </summary>
    public class TypeCasting
    {
        public static void DemonstrateCasting()
        {
            // НЕЯВНЕ ПЕРЕТВОРЕННЯ (автоматичне)
            int myInt = 100;
            double myDouble = myInt;  // int → double (OK, без втрат)
            Console.WriteLine($"int {myInt} → double {myDouble}");

            // ЯВНЕ ПЕРЕТВОРЕННЯ (вручну)
            double price = 99.99;
            int roundedPrice = (int)price;  // 99 (дробова частина відкинута!)
            Console.WriteLine($"double {price} → int {roundedPrice}");

            // ВИКОРИСТАННЯ Convert
            string ageText = "25";
            int age = Convert.ToInt32(ageText);  // Рядок → число

            double decimal_number = 3.14;
            int integer = Convert.ToInt32(decimal_number);  // 3

            // ВИКОРИСТАННЯ Parse
            string numberText = "123";
            int number = int.Parse(numberText);

            double pi = double.Parse("3.14");

            Console.WriteLine($"Конвертовано: вік={age}, число={number}, π={pi}");

            // БЕЗПЕЧНЕ ПЕРЕТВОРЕННЯ з TryParse
            string input = "abc";
            bool success = int.TryParse(input, out int result);
            if (success)
                Console.WriteLine($"Конвертовано: {result}");
            else
                Console.WriteLine("Помилка конвертації!");
        }
    }
}
