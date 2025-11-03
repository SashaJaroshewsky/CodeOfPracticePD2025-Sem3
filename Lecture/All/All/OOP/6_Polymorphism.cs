using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 6. Polymorphism — Поліморфізм
    /// 
    /// ТЕОРІЯ:
    /// Поліморфізм — це здатність об’єктів різних класів реагувати по-різному на однаковий виклик.
    /// 
    /// ВИДИ:
    /// - Компільований (method overloading)
    /// - Рунтайм (через virtual/override)
    /// 
    /// СИНТАКСИС:
    /// virtual — в базовому класі
    /// override — у похідному класі
    /// 
    /// ПРИЗНАЧЕННЯ:
    /// Дає можливість працювати з різними об’єктами через один базовий тип
    /// </summary>
    public class Polymorphism
    {
        public class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Тварина видає звук 🐾");
            }
        }

        public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Собака гавкає 🐕");
            }
        }

        public class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Кішка нявчить 🐱");
            }
        }

        public class Parrot : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Папуга каже: Привіт! 🦜");
            }
        }

        public static void DemonstratePolymorphism()
        {
            Console.WriteLine("=== ПОЛІМОРФІЗМ ===\n");

            Animal[] animals = { new Dog(), new Cat(), new Parrot() };

            foreach (var animal in animals)
            {
                animal.Speak(); // викликається власна реалізація кожного
            }
        }
    }

}
