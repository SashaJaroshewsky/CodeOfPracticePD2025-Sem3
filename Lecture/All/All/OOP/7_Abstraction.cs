using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 7. Abstraction — Абстракція
    /// 
    /// ТЕОРІЯ:
    /// Абстракція — це процес виділення головного, приховуючи деталі реалізації.
    /// 
    /// СИНТАКСИС:
    /// abstract class — не можна створити об’єкт напряму
    /// abstract method — метод без реалізації, реалізується у спадкоємцях
    /// 
    /// ПРИЗНАЧЕННЯ:
    /// - Забезпечує базовий "контракт" для похідних класів
    /// - Дозволяє спрощувати складні системи
    /// </summary>
    public class Abstraction
    {
        public abstract class Shape
        {
            public abstract double GetArea();  // абстрактний метод

            public void Describe()
            {
                Console.WriteLine("Це фігура з площею:");
            }
        }

        public class Circle : Shape
        {
            public double Radius { get; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double GetArea() => Math.PI * Radius * Radius;
        }

        public class Rectangle : Shape
        {
            public double Width { get; }
            public double Height { get; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double GetArea() => Width * Height;
        }

        public static void DemonstrateAbstraction()
        {
            Console.WriteLine("=== АБСТРАКЦІЯ ===\n");

            Shape[] shapes =
            {
            new Circle(5),
            new Rectangle(4, 6)
        };

            foreach (var shape in shapes)
            {
                shape.Describe();
                Console.WriteLine(shape.GetArea());
                Console.WriteLine();
            }
        }
    }

}
