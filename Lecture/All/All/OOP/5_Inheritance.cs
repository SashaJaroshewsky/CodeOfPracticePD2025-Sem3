using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 5. Inheritance — Наслідування
    /// 
    /// ТЕОРІЯ:
    /// Наслідування — створення нового класу на основі існуючого
    /// 
    /// ТЕРМІНОЛОГІЯ:
    /// - Базовий клас (base class) — клас, від якого наслідуємо
    /// - Похідний клас (derived class) — клас, який наслідує
    /// 
    /// СИНТАКСИС: class Derived : Base
    /// 
    /// УСПАДКОВУЄТЬСЯ:
    /// - Публічні та protected члени
    /// - private (але не маємо доступу)
    /// НЕ УСПАДКОВУЄТЬСЯ:
    /// - Конструктори
    /// 
    /// 
    /// base — посилання на базовий клас
    /// 
    /// C# підтримує ТІЛЬКИ одиночне наслідування класів
    /// </summary>
    public class Inheritance
    {
        // Базовий клас
        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine($"Конструктор Animal: {name}");
            }

            public virtual void MakeSound()
            {
                Console.WriteLine($"{Name} видає звук");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name} спить... 💤");
            }

            public void Eat()
            {
                Console.WriteLine($"{Name} їсть");
            }
        }

        // Похідний клас Dog
        public class Dog : Animal
        {
            public string Breed { get; set; }

            // Конструктор викликає базовий конструктор через base
            public Dog(string name, int age, string breed) : base(name, age)
            {
                Breed = breed;
                Console.WriteLine($"Конструктор Dog: {breed}");
            }

            // Перевизначення методу
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} гавкає: Гав-гав! 🐕");
            }

            // Додатковий метод, специфічний для Dog
            public void Fetch()
            {
                Console.WriteLine($"{Name} приносить м'яч! 🎾");
            }
        }

        // Похідний клас Cat
        public class Cat : Animal
        {
            public bool IsIndoor { get; set; }

            public Cat(string name, int age, bool isIndoor) : base(name, age)
            {
                IsIndoor = isIndoor;
                Console.WriteLine($"Конструктор Cat");
            }

            public override void MakeSound()
            {
                Console.WriteLine($"{Name} нявчить: Мяу! 🐱");
            }

            public void Purr()
            {
                Console.WriteLine($"{Name} муркоче: мур-мур-мур...");
            }
        }

        // Ще один рівень наслідування
        public class GermanShepherd : Dog
        {
            public bool IsTrained { get; set; }

            public GermanShepherd(string name, int age, bool isTrained)
                : base(name, age, "Німецька вівчарка")
            {
                IsTrained = isTrained;
            }

            public void Guard()
            {
                Console.WriteLine($"{Name} охороняє територію! 🛡️");
            }
        }

        public static void DemonstrateInheritance()
        {
            Console.WriteLine("=== НАСЛІДУВАННЯ ===\n");

            // Базовий клас
            Console.WriteLine("--- Animal ---");
            Animal animal = new Animal("Тварина", 5);
            animal.MakeSound();
            animal.Eat();
            animal.Sleep();

            Console.WriteLine("\n--- Dog ---");
            Dog dog = new Dog("Рекс", 3, "Лабрадор");
            dog.MakeSound();      // Перевизначений метод
            dog.Eat();            // Успадкований метод
            dog.Sleep();          // Успадкований метод
            dog.Fetch();          // Власний метод Dog

            Console.WriteLine("\n--- Cat ---");
            Cat cat = new Cat("Мурка", 2, true);
            cat.MakeSound();      // Перевизначений метод
            cat.Eat();            // Успадкований метод
            cat.Purr();           // Власний метод Cat

            Console.WriteLine("\n--- GermanShepherd ---");
            GermanShepherd shepherd = new GermanShepherd("Мухтар", 4, true);
            shepherd.MakeSound(); // Від Dog
            shepherd.Fetch();     // Від Dog
            shepherd.Guard();     // Власний метод

            // Поліморфізм (про нього детальніше в наступній темі)
            Console.WriteLine("\n--- Поліморфізм через наслідування ---");
            Animal[] animals = { dog, cat, shepherd };
            foreach (Animal a in animals)
            {
                a.MakeSound();  // Викликається відповідна версія методу
            }
        }
    }
}
