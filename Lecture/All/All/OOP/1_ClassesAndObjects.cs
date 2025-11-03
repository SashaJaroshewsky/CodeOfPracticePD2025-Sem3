using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 1. ClassesAndObjects — Класи та об'єкти
    /// 
    /// ТЕОРІЯ:
    /// КЛАС — шаблон/креслення для створення об'єктів
    /// ОБ'ЄКТ — конкретний екземпляр класу
    /// 
    /// КЛАС МІСТИТЬ:
    /// - Поля (fields) — змінні
    /// - Властивості (properties) — контрольований доступ до полів
    /// - Методи (methods) — функціонал
    /// - Конструктори (constructors) — ініціалізація об'єкта
    /// 
    /// АНАЛОГІЯ:
    /// Клас "Автомобіль" — креслення
    /// Об'єкт "мій Toyota Camry" — конкретна машина
    /// </summary>
    public class ClassesAndObjects
    {
        // Приклад простого класу
        public class Person
        {
            // Поля (fields) — приватні змінні
            private string name;
            private int age;

            // Властивості (properties) — публічний доступ
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 0)
                        age = value;
                }
            }

            // Метод
            public void Introduce()
            {
                Console.WriteLine($"Привіт, мене звати {name}, мені {age} років.");
            }

            public void HaveBirthday()
            {
                age++;
                Console.WriteLine($"День народження! Тепер мені {age} років.");
            }
        }

        // Клас для автомобіля
        public class Car
        {
            public string Brand;
            public string Model;
            public int Year;
            public string Color;

            public void DisplayInfo()
            {
                Console.WriteLine($"{Brand} {Model} ({Year}) - {Color}");
            }

            public void Start()
            {
                Console.WriteLine($"{Brand} {Model} заводиться... Врум-врум!");
            }

            public void Stop()
            {
                Console.WriteLine($"{Brand} {Model} зупинився.");
            }
        }

        public static void DemonstrateClasses()
        {
            Console.WriteLine("=== СТВОРЕННЯ ОБ'ЄКТІВ ===");

            // Створення об'єкта Person
            Person person1 = new Person();
            person1.Name = "Іван";
            person1.Age = 25;
            person1.Introduce();
            person1.HaveBirthday();

            // Ще один об'єкт Person
            Person person2 = new Person();
            person2.Name = "Марія";
            person2.Age = 22;
            person2.Introduce();

            Console.WriteLine("\n=== АВТОМОБІЛІ ===");

            // Створення об'єктів Car
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2020;
            car1.Color = "Чорний";

            Car car2 = new Car();
            car2.Brand = "BMW";
            car2.Model = "X5";
            car2.Year = 2022;
            car2.Color = "Білий";

            car1.DisplayInfo();
            car1.Start();

            car2.DisplayInfo();
            car2.Start();

            Console.WriteLine("\nКЛАС — це шаблон, ОБ'ЄКТ — це конкретний екземпляр");
        }
    }
}
