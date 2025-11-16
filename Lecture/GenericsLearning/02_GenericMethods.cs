/// <summary>
/// Дженерік методи (Generic Methods)
/// 
/// Дженерік методи - це методи, які мають власні параметри типу.
/// Вони можуть бути визначені як в звичайних класах, так і в дженерік класах.
/// 
/// СИНТАКСИС:
/// public T MethodName<T>(T parameter) { ... }
/// 
/// КОЛИ ВИКОРИСТОВУВАТИ?
/// - Коли потрібна операція для різних типів даних
/// - Коли весь клас робити дженеріком не потрібно
/// - Для утилітних методів (swap, print, compare тощо)
/// </summary>
namespace GenericsLearning
{
    // Звичайний клас з дженерік методами
    public class GenericMethodsExample
    {
        // Простий дженерік метод для виводу значення
        // T - параметр типу, який визначається під час виклику методу
        public void PrintValue<T>(T value)
        {
            Console.WriteLine($"Значення: {value}, Тип: {typeof(T).Name}");
        }

        // Дженерік метод для обміну значень двох змінних
        // ref - передача параметру за посиланням (щоб змінити оригінальну змінну)
        public void Swap<T>(ref T first, ref T second)
        {
            T temp = first;  // Зберігаємо перше значення в тимчасову змінну
            first = second;  // Присвоюємо друге значення першій змінній
            second = temp;   // Присвоюємо збережене значення другій змінній
        }

        // Дженерік метод для пошуку елемента в масиві
        // where T : IEquatable<T> - обмеження типу (про це в наступних уроках)
        public int FindIndex<T>(T[] array, T valueToFind) where T : IEquatable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                // Використовуємо Equals для порівняння
                if (array[i].Equals(valueToFind))
                {
                    return i; // Повертаємо індекс знайденого елемента
                }
            }
            return -1; // Елемент не знайдено
        }

        // Дженерік метод з кількома параметрами типу
        // Корисно, коли потрібно працювати з різними типами одночасно
        public void PrintPair<TFirst, TSecond>(TFirst first, TSecond second)
        {
            Console.WriteLine($"Пара: ({first}, {second})");
            Console.WriteLine($"Типи: ({typeof(TFirst).Name}, {typeof(TSecond).Name})");
        }

        // Дженерік метод, який повертає значення
        public T GetDefault<T>()
        {
            // default(T) повертає значення за замовчуванням для типу T
            // для int це 0, для string це null, для bool це false
            return default(T);
        }

        // Дженерік метод для створення масиву заповненого одним значенням
        public T[] CreateArray<T>(T value, int size)
        {
            T[] array = new T[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = value;
            }
            return array;
        }
    }

    // Клас для демонстрації використання
    public class GenericMethodsDemo
    {
        public static void RunExamples()
        {
            GenericMethodsExample example = new GenericMethodsExample();

            Console.WriteLine("=== Метод PrintValue ===");
            example.PrintValue(42);           // T буде int
            example.PrintValue("Hello");      // T буде string
            example.PrintValue(3.14);         // T буде double
            example.PrintValue(true);         // T буде bool

            Console.WriteLine("\n=== Метод Swap ===");
            int a = 10, b = 20;
            Console.WriteLine($"До обміну: a = {a}, b = {b}");
            example.Swap(ref a, ref b);
            Console.WriteLine($"Після обміну: a = {a}, b = {b}");

            string x = "Hello", y = "World";
            Console.WriteLine($"До обміну: x = {x}, y = {y}");
            example.Swap(ref x, ref y);
            Console.WriteLine($"Після обміну: x = {x}, y = {y}");

            Console.WriteLine("\n=== Метод FindIndex ===");
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = example.FindIndex(numbers, 3);
            Console.WriteLine($"Індекс числа 3: {index}");

            string[] words = { "apple", "banana", "cherry" };
            int wordIndex = example.FindIndex(words, "banana");
            Console.WriteLine($"Індекс слова 'banana': {wordIndex}");

            Console.WriteLine("\n=== Метод PrintPair ===");
            example.PrintPair(1, "один");
            example.PrintPair("Name", 25);
            example.PrintPair(true, 3.14);

            Console.WriteLine("\n=== Метод GetDefault ===");
            int defaultInt = example.GetDefault<int>();
            string defaultString = example.GetDefault<string>();
            bool defaultBool = example.GetDefault<bool>();
            Console.WriteLine($"Default int: {defaultInt}");
            Console.WriteLine($"Default string: {defaultString ?? "null"}");
            Console.WriteLine($"Default bool: {defaultBool}");

            Console.WriteLine("\n=== Метод CreateArray ===");
            int[] intArray = example.CreateArray(5, 3);
            Console.WriteLine($"Масив int: [{string.Join(", ", intArray)}]");

            string[] stringArray = example.CreateArray("test", 4);
            Console.WriteLine($"Масив string: [{string.Join(", ", stringArray)}]");
        }
    }
}