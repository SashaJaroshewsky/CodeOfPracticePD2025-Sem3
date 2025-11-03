using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 4. Operators — Оператори
    /// 
    /// ТЕОРІЯ:
    /// АРИФМЕТИЧНІ: +, -, *, /, % (остача від ділення)
    /// ПОРІВНЯННЯ: ==, !=, >, <, >=, <=
    /// ЛОГІЧНІ: && (і), || (або), ! (не)
    /// ПРИСВОЄННЯ: =, +=, -=, *=, /=, %=
    /// ІНКРЕМЕНТ/ДЕКРЕМЕНТ: ++, --
    /// </summary>
    public class Operators
    {
        public static void DemonstrateOperators()
        {
            // АРИФМЕТИЧНІ ОПЕРАТОРИ
            int a = 10, b = 3;
            int sum = a + b;        // 13
            int diff = a - b;       // 7
            int prod = a * b;       // 30
            int quot = a / b;       // 3 (цілочисельне ділення!)
            int rem = a % b;        // 1 (остача)

            Console.WriteLine($"10 / 3 = {quot}, остача = {rem}");

            // ОПЕРАТОРИ ПОРІВНЯННЯ (результат — bool)
            bool isEqual = a == b;      // false
            bool isNotEqual = a != b;   // true
            bool isGreater = a > b;     // true
            bool isLessOrEqual = a <= b;// false

            // ЛОГІЧНІ ОПЕРАТОРИ
            bool result1 = a > 5 && b < 5;  // true && true = true
            bool result2 = a < 5 || b > 5;  // false || false = false
            bool result3 = !(a == b);           // !false = true

            // ОПЕРАТОРИ ПРИСВОЄННЯ
            int x = 10;
            x += 5;  // x = x + 5, тепер x = 15
            x -= 3;  // x = x - 3, тепер x = 12
            x *= 2;  // x = x * 2, тепер x = 24
            x /= 4;  // x = x / 4, тепер x = 6

            // ІНКРЕМЕНТ ТА ДЕКРЕМЕНТ
            int y = 5;
            y++;     // y = y + 1, тепер y = 6
            y--;     // y = y - 1, тепер y = 5
            --y;    //
            ++y;

            Console.WriteLine($"Результат: x = {x}, y = {y}");
        }
    }
}
