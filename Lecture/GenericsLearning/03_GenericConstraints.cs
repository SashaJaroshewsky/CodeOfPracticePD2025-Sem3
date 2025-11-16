/// <summary>
/// Обмеження дженеріків (Generic Constraints)
/// 
/// Обмеження дозволяють вказати, які типи можуть бути використані з дженеріками.
/// Це дає можливість використовувати специфічні методи та властивості цих типів.
/// 
/// ТИПИ ОБМЕЖЕНЬ:
/// where T : struct          - T має бути структурою (value type)
/// where T : class           - T має бути класом (reference type)
/// where T : new()           - T має мати конструктор без параметрів
/// where T : BaseClass       - T має успадковуватись від BaseClass
/// where T : IInterface      - T має реалізовувати IInterface
/// where T : U               - T має бути або успадковувати тип U
/// 
/// Можна комбінувати кілька обмежень через кому
/// </summary>
namespace GenericsLearning
{
    // === ПРИКЛАД 1: Обмеження struct (лише типи значень) ===
    // Корисно для математичних операцій, калькуляторів тощо
    public class Calculator<T> where T : struct
    {
        // T може бути лише int, double, decimal, bool тощо
        // НЕ може бути string, class, interface

        public T Add(T a, T b)
        {
            // dynamic дозволяє виконувати операції під час виконання
            dynamic da = a;
            dynamic db = b;
            return da + db;
        }

        public void PrintType()
        {
            Console.WriteLine($"Працюємо з типом значення: {typeof(T).Name}");
        }
    }

    // === ПРИКЛАД 2: Обмеження class (лише посилальні типи) ===
    public class Repository<T> where T : class
    {
        // T може бути лише класами (string, Customer, Product тощо)
        // НЕ може бути int, double, struct

        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            // Можемо перевірити на null, бо це reference type
            if (item == null)
            {
                Console.WriteLine("Неможливо додати null об'єкт");
                return;
            }
            _items.Add(item);
        }

        public int Count => _items.Count;
    }

    // === ПРИКЛАД 3: Обмеження new() (потрібен конструктор без параметрів) ===
    public class Factory<T> where T : new()
    {
        // T має мати конструктор без параметрів
        // Це дозволяє створювати нові екземпляри типу T

        public T CreateInstance()
        {
            // Можемо створити новий об'єкт типу T
            return new T();
        }

        public List<T> CreateMultiple(int count)
        {
            List<T> items = new List<T>();
            for (int i = 0; i < count; i++)
            {
                items.Add(new T()); // Створюємо новий екземпляр
            }
            return items;
        }
    }

    // === ПРИКЛАД 4: Обмеження інтерфейсом ===
    // Базовий клас для прикладу
    public class Animal
    {
        public string Name { get; set; }
    }

    public class Dog : Animal
    {
        public void Bark() => Console.WriteLine($"{Name} гавкає!");
    }

    public class Cat : Animal
    {
        public void Meow() => Console.WriteLine($"{Name} нявкає!");
    }

    // Клас, який працює лише з Animal та його нащадками
    public class AnimalShelter<T> where T : Animal
    {
        private List<T> _animals = new List<T>();

        public void AddAnimal(T animal)
        {
            _animals.Add(animal);
            // Можемо використовувати властивості Animal, бо T : Animal
            Console.WriteLine($"Додано тварину: {animal.Name}");
        }

        public void PrintAll()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine($"- {animal.Name}");
            }
        }
    }

    // === ПРИКЛАД 5: Комбінування обмежень ===
    // T має бути класом, успадковувати Animal і мати конструктор без параметрів
    public class AdvancedFactory<T> where T : Animal, new()
    {
        public T CreateAnimal(string name)
        {
            T animal = new T(); // Можемо створити, бо є new()
            animal.Name = name; // Можемо встановити Name, бо є Animal
            return animal;
        }
    }

    // === ПРИКЛАД 6: Обмеження з інтерфейсом IComparable ===
    public class Sorter<T> where T : IComparable<T>
    {
        // T має реалізовувати IComparable<T>
        // Це дозволяє порівнювати елементи

        public T FindMax(T[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Масив порожній");

            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                // Можемо використовувати CompareTo, бо T : IComparable<T>
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }

    // Клас для демонстрації
    public class GenericConstraintsDemo
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== 1. Обмеження struct ===");
            Calculator<int> intCalc = new Calculator<int>();
            Console.WriteLine($"10 + 5 = {intCalc.Add(10, 5)}");

            Calculator<double> doubleCalc = new Calculator<double>();
            Console.WriteLine($"3.14 + 2.86 = {doubleCalc.Add(3.14, 2.86)}");
            // Calculator<string> stringCalc = new Calculator<string>(); // ПОМИЛКА компіляції!

            Console.WriteLine("\n=== 2. Обмеження class ===");
            Repository<string> stringRepo = new Repository<string>();
            stringRepo.Add("Hello");
            stringRepo.Add("World");
            Console.WriteLine($"Кількість елементів: {stringRepo.Count}");
            // Repository<int> intRepo = new Repository<int>(); // ПОМИЛКА компіляції!

            Console.WriteLine("\n=== 3. Обмеження new() ===");
            Factory<Dog> dogFactory = new Factory<Dog>();
            Dog dog = dogFactory.CreateInstance();
            dog.Name = "Бобік";
            dog.Bark();

            Console.WriteLine("\n=== 4. Обмеження базовим класом ===");
            AnimalShelter<Dog> dogShelter = new AnimalShelter<Dog>();
            dogShelter.AddAnimal(new Dog { Name = "Рекс" });
            dogShelter.AddAnimal(new Dog { Name = "Шарик" });
            dogShelter.PrintAll();

            Console.WriteLine("\n=== 5. Комбінування обмежень ===");
            AdvancedFactory<Cat> catFactory = new AdvancedFactory<Cat>();
            Cat cat = catFactory.CreateAnimal("Мурчик");
            cat.Meow();

            Console.WriteLine("\n=== 6. Обмеження IComparable ===");
            Sorter<int> sorter = new Sorter<int>();
            int[] numbers = { 5, 2, 8, 1, 9 };
            Console.WriteLine($"Максимальне число: {sorter.FindMax(numbers)}");

            Sorter<string> stringSorter = new Sorter<string>();
            string[] words = { "apple", "zebra", "banana" };
            Console.WriteLine($"Максимальне слово: {stringSorter.FindMax(words)}");
        }
    }
}