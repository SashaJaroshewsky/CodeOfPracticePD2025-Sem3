using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 2. Constructors — Конструктори
    /// 
    /// ТЕОРІЯ:
    /// Конструктор — спеціальний метод для ініціалізації об'єкта
    /// 
    /// ОСОБЛИВОСТІ:
    /// - Має таке саме ім'я, як клас
    /// - Не має типу повернення
    /// - Викликається автоматично при створенні об'єкта
    /// 
    /// ВИДИ:
    /// - Конструктор за замовчуванням (без параметрів)
    /// - Конструктор з параметрами
    /// - Перевантажені конструктори
    /// - Статичний конструктор
    /// 
    /// this — посилання на поточний об'єкт
    /// </summary>
    public class Constructors
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Major { get; set; }

            // Конструктор за замовчуванням
            public Student()
            {
                Name = "Невідомий";
                Age = 18;
                Major = "Не вказано";
                Console.WriteLine("Викликано конструктор за замовчуванням");
            }

            // Конструктор з параметрами
            public Student(string name, int age)
            {
                Name = name;
                Age = age;
                Major = "Не вказано";
                Console.WriteLine("Викликано конструктор з 2 параметрами");
            }

            // Перевантажений конструктор
            public Student(string name, int age, string major)
            {
                Name = name;
                Age = age;
                Major = major;
                Console.WriteLine("Викликано конструктор з 3 параметрами");
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Студент: {Name}, {Age} років, Спеціальність: {Major}");
            }
        }

        // Клас з this для виклику іншого конструктора
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }

            // Базовий конструктор
            public Book(string title, string author, int pages)
            {
                Title = title;
                Author = author;
                Pages = pages;
            }

            // Конструктор викликає інший конструктор через this
            public Book(string title, string author) : this(title, author, 0)
            {
                Console.WriteLine("Кількість сторінок не вказана");
            }

            // Конструктор з одним параметром
            public Book(string title) : this(title, "Невідомий автор")
            {
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"'{Title}' — {Author}, {Pages} стор.");
            }
        }

        // Клас зі статичним конструктором
        public class Database
        {
            public static string ConnectionString { get; set; }

            // Статичний конструктор — викликається один раз при першому звертанні до класу
            static Database()
            {
                ConnectionString = "Server=localhost;Database=MyDB";
                Console.WriteLine("Статичний конструктор Database викликано");
                Console.WriteLine($"ConnectionString: {ConnectionString}");
            }

            public Database()
            {
                Console.WriteLine("Створено екземпляр Database");
            }
        }

        public static void DemonstrateConstructors()
        {
            Console.WriteLine("=== КОНСТРУКТОРИ ===\n");

            // Виклик різних конструкторів
            Student s1 = new Student();
            s1.DisplayInfo();

            Console.WriteLine();
            Student s2 = new Student("Олена", 20);
            s2.DisplayInfo();

            Console.WriteLine();
            Student s3 = new Student("Петро", 22, "Комп'ютерні науки");
            s3.DisplayInfo();

            Console.WriteLine("\n=== ВИКЛИК КОНСТРУКТОРІВ ЧЕРЕЗ this ===\n");

            Book b1 = new Book("C# для початківців");
            b1.DisplayInfo();

            Book b2 = new Book("Чистий код", "Роберт Мартін");
            b2.DisplayInfo();

            Book b3 = new Book("Патерни проектування", "Gang of Four", 395);
            b3.DisplayInfo();

            Console.WriteLine("\n=== СТАТИЧНИЙ КОНСТРУКТОР ===\n");
            Database db1 = new Database();
            Database db2 = new Database();
            // Статичний конструктор викликався лише один раз!
        }
    }
}
