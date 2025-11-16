/// <summary>
/// Кращі практики роботи з дженеріками (Best Practices)
/// 
/// Цей клас демонструє правильні підходи до використання дженеріків,
/// типові помилки та як їх уникати.
/// 
/// ОСНОВНІ ПРИНЦИПИ:
/// 1. Використовуйте зрозумілі назви параметрів типу
/// 2. Застосовуйте обмеження типів для безпеки
/// 3. Віддавайте перевагу дженерікам перед object
/// 4. Використовуйте коваріантність та контраваріантність правильно
/// 5. Не переускладнюйте - простота важлива
/// </summary>
namespace GenericsLearning
{
    // === 1. ПРАВИЛЬНІ НАЗВИ ПАРАМЕТРІВ ТИПУ ===

    // ❌ ПОГАНО: незрозумілі назви
    public class BadNaming<A, B, C>
    {
        public A DoSomething(B input, C other) => default;
    }

    // ✅ ДОБРЕ: зрозумілі назви
    public class GoodNaming<TEntity, TKey, TValue>
    {
        public TEntity GetEntity(TKey key, TValue value) => default;
    }

    // Загальноприйняті конвенції назв:
    // T - загальний тип (Type)
    // TEntity - сутність
    // TKey - ключ
    // TValue - значення
    // TResult - результат
    // TInput, TOutput - вхід/вихід
    // TCriteria - критерій

    // === 2. ВИКОРИСТАННЯ ОБМЕЖЕНЬ ДЛЯ БЕЗПЕКИ ===

    // ❌ ПОГАНО: без обмежень, можливі помилки під час виконання
    public class WithoutConstraints<T>
    {
        public void Process(T item)
        {
            // Що якщо T не має ToString або інших методів?
            // Доведеться використовувати рефлексію або dynamic
        }
    }

    // ✅ ДОБРЕ: з обмеженнями
    public class WithConstraints<T> where T : IComparable<T>, new()
    {
        public void Process(T item)
        {
            // Можемо безпечно використовувати CompareTo
            T newItem = new T(); // Можемо створювати екземпляри

            if (item.CompareTo(newItem) > 0)
            {
                Console.WriteLine("item більше newItem");
            }
        }
    }

    // === 3. УНИКАЙТЕ НАД-ДЖЕНЕРИФІКАЦІЇ ===

    // ❌ ПОГАНО: надто складно
    public class OverEngineered<T1, T2, T3, T4, T5>
        where T1 : class
        where T2 : struct
        where T3 : IEnumerable<T1>
        where T4 : IComparable<T2>
        where T5 : new()
    {
        // Занадто багато параметрів типу робить код важким для розуміння
    }

    // ✅ ДОБРЕ: простіше та зрозуміліше
    public class SimpleAndClear<TEntity> where TEntity : class, new()
    {
        // Один параметр типу з необхідними обмеженнями
        public List<TEntity> Items { get; } = new List<TEntity>();
    }

    // === 4. ПРАВИЛЬНА РОБОТА З NULL ===

    public class NullHandling<T>
    {
        // ❌ ПОГАНО: не враховуємо, що T може бути value type
        public bool IsNull(T value)
        {
            // return value == null; // Помилка для value types!
            return false;
        }

        // ✅ ДОБРЕ: правильна перевірка
        public bool IsNullOrDefault(T value)
        {
            return EqualityComparer<T>.Default.Equals(value, default(T));
        }

        // Для reference types можна використати обмеження
        public bool IsNullReference<TRef>(TRef value) where TRef : class
        {
            return value == null; // Безпечно для class
        }
    }

    // === 5. ЕФЕКТИВНЕ ВИКОРИСТАННЯ DEFAULT ===

    public class DefaultValues<T>
    {
        // default(T) повертає значення за замовчуванням
        public T GetDefault()
        {
            // Для int - 0
            // Для string - null
            // Для bool - false
            // Для class - null
            return default(T);
        }

        // Сучасний синтаксис (C# 7.1+)
        public T GetDefaultModern()
        {
            return default; // Компілятор сам визначає тип
        }
    }

    // === 6. КЕШУВАННЯ ТА ПРОДУКТИВНІСТЬ ===

    public class CachingExample<T>
    {
        // Статичний словник для кешування
        // УВАГА: кожен тип T матиме власний кеш!
        private static readonly Dictionary<string, T> _cache = new Dictionary<string, T>();

        public T GetOrCreate(string key, Func<T> factory)
        {
            if (_cache.TryGetValue(key, out T value))
            {
                return value;
            }

            value = factory();
            _cache[key] = value;
            return value;
        }

        public static void ClearCache()
        {
            _cache.Clear();
        }
    }

    // === 7. РОБОТА З КОЛЕКЦІЯМИ ===

    public class CollectionBestPractices
    {
        // ❌ ПОГАНО: повертаємо внутрішню колекцію
        public class BadRepository<T>
        {
            private List<T> _items = new List<T>();

            public List<T> GetAll()
            {
                return _items; // Зовнішній код може змінити колекцію!
            }
        }

        // ✅ ДОБРЕ: повертаємо копію або readonly
        public class GoodRepository<T>
        {
            private List<T> _items = new List<T>();

            // Варіант 1: Повертаємо копію
            public List<T> GetAll()
            {
                return new List<T>(_items);
            }

            // Варіант 2: Повертаємо IReadOnlyList
            public IReadOnlyList<T> GetAllReadOnly()
            {
                return _items.AsReadOnly();
            }

            // Варіант 3: Повертаємо IEnumerable (найбільш гнучко)
            public IEnumerable<T> GetAllEnumerable()
            {
                return _items; // Можна лише перебирати
            }
        }
    }

    // === 8. КОМПОЗИЦІЯ ЗАМІСТЬ УСПАДКУВАННЯ ===

    // ❌ ПОГАНО: глибока ієрархія успадкування
    public class DeepHierarchy<T> : List<T>
    {
        // Успадкування від List<T> обмежує гнучкість
    }

    // ✅ ДОБРЕ: композиція
    public class GoodComposition<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            // Можемо додати додаткову логіку
            Console.WriteLine($"Додаємо: {item}");
            _items.Add(item);
        }

        public IEnumerable<T> Items => _items;
    }

    // === 9. ТЕСТУВАННЯ ДЖЕНЕРІК КОДУ ===

    public class TestableGeneric<T>
    {
        private readonly IEqualityComparer<T> _comparer;

        // Dependency Injection для тестування
        public TestableGeneric(IEqualityComparer<T> comparer = null)
        {
            _comparer = comparer ?? EqualityComparer<T>.Default;
        }

        public bool AreEqual(T first, T second)
        {
            return _comparer.Equals(first, second);
        }

        // Метод для фільтрації
        public List<T> Filter(IEnumerable<T> items, Predicate<T> predicate)
        {
            var result = new List<T>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }

    // === 10. ДОКУМЕНТУВАННЯ ДЖЕНЕРІК КОДУ ===

    /// <summary>
    /// Репозиторій для роботи з сутностями
    /// </summary>
    /// <typeparam name="TEntity">Тип сутності, має мати Id</typeparam>
    /// <typeparam name="TKey">Тип ключа для пошуку</typeparam>
    public class DocumentedRepository<TEntity, TKey>
        where TEntity : class
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Додає нову сутність до репозиторію
        /// </summary>
        /// <param name="entity">Сутність для додавання</param>
        /// <exception cref="ArgumentNullException">Якщо entity є null</exception>
        public void Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // Логіка додавання
        }

        /// <summary>
        /// Отримує сутність за ключем
        /// </summary>
        /// <param name="key">Ключ для пошуку</param>
        /// <returns>Знайдену сутність або null</returns>
        public TEntity GetByKey(TKey key)
        {
            // Логіка пошуку
            return null;
        }
    }

    // === 11. ПРАКТИЧНІ ПРИКЛАДИ ===

    // Приклад: Result<T> pattern для обробки помилок
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public string Error { get; }

        private Result(bool isSuccess, T value, string error)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
        }

        public static Result<T> Success(T value)
        {
            return new Result<T>(true, value, null);
        }

        public static Result<T> Failure(string error)
        {
            return new Result<T>(false, default, error);
        }

        // Fluent API для обробки результату
        public Result<TNew> Map<TNew>(Func<T, TNew> mapper)
        {
            if (!IsSuccess)
                return Result<TNew>.Failure(Error);

            return Result<TNew>.Success(mapper(Value));
        }
    }

    // === ДЕМОНСТРАЦІЯ ===

    public class BestPracticesDemo
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== 1. Обробка null/default ===");
            var nullHandler = new NullHandling<int>();
            Console.WriteLine($"0 є default для int? {nullHandler.IsNullOrDefault(0)}");
            Console.WriteLine($"5 є default для int? {nullHandler.IsNullOrDefault(5)}");

            var stringHandler = new NullHandling<string>();
            Console.WriteLine($"null є default для string? {stringHandler.IsNullOrDefault(null)}");

            Console.WriteLine("\n=== 2. Кешування ===");
            var cache = new CachingExample<string>();

            string value1 = cache.GetOrCreate("key1", () => {
                Console.WriteLine("Створюємо нове значення для key1");
                return "Value 1";
            });

            string value2 = cache.GetOrCreate("key1", () => {
                Console.WriteLine("Це не виконається - значення в кеші");
                return "Value 2";
            });

            Console.WriteLine($"value1: {value1}");
            Console.WriteLine($"value2 (з кешу): {value2}");

            Console.WriteLine("\n=== 3. Безпечна робота з колекціями ===");
            var repo = new CollectionBestPractices.GoodRepository<int>();

            // Клієнтський код не може змінити внутрішню колекцію
            var items = repo.GetAllEnumerable();
            Console.WriteLine($"Отримано {items.Count()} елементів");

            Console.WriteLine("\n=== 4. Тестування ===");
            var testable = new TestableGeneric<int>();
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Фільтруємо парні числа
            var evenNumbers = testable.Filter(numbers, n => n % 2 == 0);
            Console.WriteLine($"Парні числа: {string.Join(", ", evenNumbers)}");

            Console.WriteLine("\n=== 5. Result<T> pattern ===");

            Result<int> successResult = Result<int>.Success(42);
            Result<int> failureResult = Result<int>.Failure("Щось пішло не так");

            Console.WriteLine($"Успіх? {successResult.IsSuccess}, Значення: {successResult.Value}");
            Console.WriteLine($"Помилка? {!failureResult.IsSuccess}, Повідомлення: {failureResult.Error}");

            // Ланцюжок операцій
            var mappedResult = successResult.Map(x => x * 2);
            Console.WriteLine($"Після Map: {mappedResult.Value}");

            Console.WriteLine("\n=== КЛЮЧОВІ ПОРАДИ ===");
            Console.WriteLine("✓ Використовуйте зрозумілі назви типів (TEntity, TKey)");
            Console.WriteLine("✓ Додавайте обмеження для безпеки типів");
            Console.WriteLine("✓ Не переускладнюйте - простота важлива");
            Console.WriteLine("✓ Документуйте параметри типу");
            Console.WriteLine("✓ Повертайте IEnumerable замість конкретних колекцій");
            Console.WriteLine("✓ Використовуйте композицію замість успадкування");
            Console.WriteLine("✓ Тестуйте з різними типами");
            Console.WriteLine("✓ Пам'ятайте про статичні члени в дженеріках");
        }
    }
}