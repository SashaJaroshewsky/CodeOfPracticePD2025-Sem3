using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 6. Structs — Структури
    /// 
    /// ТЕОРІЯ:
    /// Struct — тип значення (на відміну від класу — типу посилання)
    /// 
    /// ВІДМІННОСТІ від CLASS:
    /// - Зберігається в стеку (швидше)
    /// - Не може бути null (без nullable)
    /// - Не підтримує наслідування
    /// - Копіюється за значенням
    /// 
    /// КОЛИ ВИКОРИСТОВУВАТИ:
    /// - Для невеликих структур даних
    /// - Коли потрібна продуктивність
    /// - Для незмінних (immutable) об'єктів
    /// 
    /// ПРИКЛАДИ: Point, Color, Complex числа
    /// </summary>
    public class Structs
    {
        // Структура для точки в 2D
        public struct Point
        {
            public int X;
            public int Y;

            // Конструктор
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Метод
            public double DistanceFromOrigin()
            {
                return Math.Sqrt(X * X + Y * Y);
            }

            // Override ToString
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        // Структура для кольору
        public struct Color
        {
            public byte R;
            public byte G;
            public byte B;

            public Color(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }

            // Статичні константи
            public static Color Red => new Color(255, 0, 0);
            public static Color Green => new Color(0, 255, 0);
            public static Color Blue => new Color(0, 0, 255);

            public override string ToString()
            {
                return $"RGB({R}, {G}, {B})";
            }
        }

        public static void DemonstrateStructs()
        {
            // Створення структур
            Point p1 = new Point(3, 4);
            Console.WriteLine($"Точка: {p1}");
            Console.WriteLine($"Відстань від початку: {p1.DistanceFromOrigin():F2}");

            // Структури копіюються за значенням
            Point p2 = p1;  // Створюється КОПІЯ
            p2.X = 10;      // Змінюємо копію

            Console.WriteLine($"\nОригінал p1: {p1}");  // (3, 4) — не змінився!
            Console.WriteLine($"Копія p2: {p2}");       // (10, 4)

            // Робота з Color
            Color myColor = new Color(128, 64, 200);
            Console.WriteLine($"\nМій колір: {myColor}");

            Color red = Color.Red;
            Console.WriteLine($"Червоний: {red}");

            // Різниця між struct та class
            Console.WriteLine("\n=== РІЗНИЦЯ STRUCT vs CLASS ===");
            Console.WriteLine("Struct — тип значення (копіюється)");
            Console.WriteLine("Class — тип посилання (копіюється посилання)");
        }
    }
}
