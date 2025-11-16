/// <summary>
/// Дженерік інтерфейси (Generic Interfaces)
/// 
/// Дженерік інтерфейси дозволяють визначати контракти, які працюють з різними типами.
/// Це дуже потужний механізм для створення гнучкого та повторно використовуваного коду.
/// 
/// ПОПУЛЯРНІ ВБУДОВАНІ ДЖЕНЕРІК ІНТЕРФЕЙСИ:
/// IEnumerable<T>    - дозволяє перебирати колекцію (foreach)
/// ICollection<T>    - базовий інтерфейс для колекцій
/// IList<T>          - список з доступом за індексом
/// IDictionary<K,V>  - словник
/// IComparable<T>    - порівняння об'єктів
/// IEquatable<T>     - перевірка на рівність
/// 
/// НАВІЩО СТВОРЮВАТИ ВЛАСНІ ДЖЕНЕРІК ІНТЕРФЕЙСИ?
/// - Визначення контрактів для різних типів
/// - Створення абстракцій для сховищ даних
/// - Реалізація патернів проектування (Repository, Strategy тощо)
/// </summary>
namespace GenericsLearning
{
    // === 1. Простий дженерік інтерфейс ===
    // Інтерфейс для сховища даних
    public interface IRepository<T>
    {
        void Add(T item);           // Додати елемент
        T GetById(int id);          // Отримати за ID
        List<T> GetAll();           // Отримати всі елементи
        void Update(T item);        // Оновити елемент
        void Delete(int id);        // Видалити за ID
        int Count { get; }          // Кількість елементів
    }

    // Клас Product для прикладу
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product(Id: {Id}, Name: {Name}, Price: {Price:C})";
        }
    }

    // Реалізація репозиторію для продуктів
    public class ProductRepository : IRepository<Product>
    {
        private List<Product> _products = new List<Product>();
        private int _nextId = 1;

        public void Add(Product item)
        {
            item.Id = _nextId++;
            _products.Add(item);
            Console.WriteLine($"Додано: {item}");
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return new List<Product>(_products); // Повертаємо копію
        }

        public void Update(Product item)
        {
            var existing = GetById(item.Id);
            if (existing != null)
            {
                existing.Name = item.Name;
                existing.Price = item.Price;
                Console.WriteLine($"Оновлено: {item}");
            }
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _products.Remove(item);
                Console.WriteLine($"Видалено продукт з ID: {id}");
            }
        }

        public int Count => _products.Count;
    }

    // === 2. Дженерік інтерфейс з кількома параметрами типу ===
    // Інтерфейс для конвертера
    public interface IConverter<TSource, TTarget>
    {
        TTarget Convert(TSource source);
    }

    // Клас для конвертації Product в string
    public class ProductToStringConverter : IConverter<Product, string>
    {
        public string Convert(Product source)
        {
            return $"{source.Name} - {source.Price:C}";
        }
    }

    // Клас для конвертації температури
    public class CelsiusToFahrenheitConverter : IConverter<double, double>
    {
        public double Convert(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32;
        }
    }

    // === 3. Вбудований інтерфейс IComparable<T> ===
    // Дозволяє порівнювати об'єкти
    public class Student1 : IComparable<Student1>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        // Реалізація методу порівняння (за оцінкою)
        public int CompareTo(Student1 other)
        {
            if (other == null) return 1;

            // Повертає: 
            // < 0 якщо this менше other
            // 0 якщо рівні
            // > 0 якщо this більше other
            return Grade.CompareTo(other.Grade);
        }

        public override string ToString()
        {
            return $"{Name} (Оцінка: {Grade})";
        }
    }

    // === 4. Вбудований інтерфейс IEquatable<T> ===
    // Дозволяє перевіряти рівність об'єктів
    public class Person : IEquatable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Реалізація методу перевірки рівності
        public bool Equals(Person other)
        {
            if (other == null) return false;

            // Дві персони рівні, якщо в них однаковий ID
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"Person(Id: {Id}, Name: {Name}, Age: {Age})";
        }
    }

    // === 5. Інтерфейс з обмеженнями ===
    // Інтерфейс для валідатора
    public interface IValidator<T> where T : class
    {
        bool IsValid(T item);
        string GetErrorMessage();
    }

    // Валідатор для продуктів
    public class ProductValidator : IValidator<Product>
    {
        private string _errorMessage;

        public bool IsValid(Product item)
        {
            if (item == null)
            {
                _errorMessage = "Продукт не може бути null";
                return false;
            }

            if (string.IsNullOrWhiteSpace(item.Name))
            {
                _errorMessage = "Назва продукту не може бути порожньою";
                return false;
            }

            if (item.Price <= 0)
            {
                _errorMessage = "Ціна має бути більше 0";
                return false;
            }

            _errorMessage = string.Empty;
            return true;
        }

        public string GetErrorMessage()
        {
            return _errorMessage;
        }
    }

    // === 6. Ланцюжок інтерфейсів ===
    // Створення сервісу, який використовує кілька дженерік інтерфейсів
    public class DataService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IValidator<T> _validator;

        // Dependency Injection через конструктор
        public DataService(IRepository<T> repository, IValidator<T> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public bool AddWithValidation(T item)
        {
            if (_validator.IsValid(item))
            {
                _repository.Add(item);
                return true;
            }
            else
            {
                Console.WriteLine($"Помилка валідації: {_validator.GetErrorMessage()}");
                return false;
            }
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }
    }

    // Клас для демонстрації
    public class GenericInterfacesDemo
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== 1. Простий дженерік інтерфейс (Repository) ===");
            IRepository<Product> productRepo = new ProductRepository();
            productRepo.Add(new Product { Name = "Ноутбук", Price = 25000 });
            productRepo.Add(new Product { Name = "Миша", Price = 500 });
            productRepo.Add(new Product { Name = "Клавіатура", Price = 1200 });

            Console.WriteLine($"\nВсього продуктів: {productRepo.Count}");
            Console.WriteLine("Список продуктів:");
            foreach (var product in productRepo.GetAll())
            {
                Console.WriteLine($"  {product}");
            }

            Console.WriteLine("\n=== 2. Інтерфейс з кількома параметрами (Converter) ===");
            IConverter<Product, string> converter = new ProductToStringConverter();
            var product1 = productRepo.GetById(1);
            string productString = converter.Convert(product1);
            Console.WriteLine($"Конвертовано: {productString}");

            IConverter<double, double> tempConverter = new CelsiusToFahrenheitConverter();
            double celsius = 25;
            double fahrenheit = tempConverter.Convert(celsius);
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

            Console.WriteLine("\n=== 3. IComparable<T> - Порівняння об'єктів ===");
            List<Student1> students = new List<Student1>
            {
                new Student1 { Id = 1, Name = "Іван", Grade = 85.5 },
                new Student1 { Id = 2, Name = "Марія", Grade = 92.0 },
                new Student1 { Id = 3, Name = "Петро", Grade = 78.3 }
            };

            Console.WriteLine("До сортування:");
            students.ForEach(s => Console.WriteLine($"  {s}"));

            students.Sort(); // Використовує CompareTo з IComparable<T>

            Console.WriteLine("\nПісля сортування за оцінкою:");
            students.ForEach(s => Console.WriteLine($"  {s}"));

            Console.WriteLine("\n=== 4. IEquatable<T> - Перевірка рівності ===");
            Person person1 = new Person { Id = 1, Name = "Олег", Age = 25 };
            Person person2 = new Person { Id = 1, Name = "Олег Іванов", Age = 26 };
            Person person3 = new Person { Id = 2, Name = "Марія", Age = 25 };

            Console.WriteLine($"person1 == person2? {person1.Equals(person2)}"); // true (однаковий ID)
            Console.WriteLine($"person1 == person3? {person1.Equals(person3)}"); // false (різний ID)

            Console.WriteLine("\n=== 5. Інтерфейс з обмеженнями (Validator) ===");
            IValidator<Product> validator = new ProductValidator();

            Product validProduct = new Product { Name = "Монітор", Price = 5000 };
            Product invalidProduct = new Product { Name = "", Price = -100 };

            Console.WriteLine($"validProduct валідний? {validator.IsValid(validProduct)}");
            Console.WriteLine($"invalidProduct валідний? {validator.IsValid(invalidProduct)}");
            Console.WriteLine($"Помилка: {validator.GetErrorMessage()}");

            Console.WriteLine("\n=== 6. Композиція сервісів ===");
            DataService<Product> dataService = new DataService<Product>(productRepo, validator);

            Console.WriteLine("\nСпроба додати валідний продукт:");
            dataService.AddWithValidation(new Product { Name = "Принтер", Price = 3000 });

            Console.WriteLine("\nСпроба додати невалідний продукт:");
            dataService.AddWithValidation(new Product { Name = "", Price = 0 });

            Console.WriteLine("\n=== Переваги дженерік інтерфейсів ===");
            Console.WriteLine("✓ Типобезпека");
            Console.WriteLine("✓ Можливість використання з різними типами");
            Console.WriteLine("✓ Легко тестувати (mock interfaces)");
            Console.WriteLine("✓ Відповідність принципам SOLID");
            Console.WriteLine("✓ Зменшення дублювання коду");
        }
    }
}