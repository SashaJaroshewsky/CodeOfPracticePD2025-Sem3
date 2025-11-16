/// <summary>
/// Введення в Дженеріки (Generics)
/// 
/// Дженеріки - це механізм, який дозволяє створювати класи, методи, інтерфейси та делегати,
/// які працюють з різними типами даних без втрати типобезпеки (type safety).
/// 
/// ЧОМУ ЦЕ ПОТРІБНО?
/// - Уникнення дублювання коду
/// - Типобезпека під час компіляції
/// - Покращена продуктивність (без boxing/unboxing)
/// - Можливість повторного використання коду
/// 
/// ПРИКЛАД БЕЗ ДЖЕНЕРІКІВ (старий підхід):
/// Якщо потрібно зберігати різні типи даних, доводилось використовувати object
/// </summary>
namespace GenericsLearning
{
    // Приклад БЕЗ дженеріків - поганий підхід
    public class BoxWithoutGenerics
    {
        private object _value; // object може зберігати будь-який тип

        public void SetValue(object value)
        {
            _value = value;
        }

        public object GetValue()
        {
            return _value;
        }
    }

    // Приклад З дженеріками - правильний підхід
    // T - це параметр типу (type parameter), який буде замінено на конкретний тип
    public class Box<T>
    {
        private T _value; // T буде замінено на конкретний тип (int, string, тощо)

        public void SetValue(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }
    }

    // Клас для демонстрації використання
    public class GenericsIntroductionDemo
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== Приклад БЕЗ дженеріків ===");

            // Проблема 1: Потрібно приведення типу (casting)
            BoxWithoutGenerics oldBox = new BoxWithoutGenerics();
            oldBox.SetValue(42);
            int number = (int)oldBox.GetValue(); // Потрібно явне приведення типу
            Console.WriteLine($"Значення з oldBox: {number}");

            // Проблема 2: Можна помилитися з типом під час виконання
            oldBox.SetValue("Hello");
            // int wrongType = (int)oldBox.GetValue(); // ПОМИЛКА під час виконання!

            Console.WriteLine("\n=== Приклад З дженеріками ===");

            // Переваги дженеріків
            Box<int> intBox = new Box<int>(); // Створюємо коробку для int
            intBox.SetValue(42);
            int intValue = intBox.GetValue(); // Не потрібно приведення типу!
            Console.WriteLine($"Значення з intBox: {intValue}");

            Box<string> stringBox = new Box<string>(); // Створюємо коробку для string
            stringBox.SetValue("Hello, Generics!");
            string stringValue = stringBox.GetValue();
            Console.WriteLine($"Значення з stringBox: {stringValue}");

            // Помилка буде виявлена під час компіляції, а не виконання!
            // stringBox.SetValue(42); // ПОМИЛКА компіляції - не можна присвоїти int до Box<string>

            Console.WriteLine("\n=== Переваги дженеріків ===");
            Console.WriteLine("✓ Типобезпека під час компіляції");
            Console.WriteLine("✓ Немає потреби в приведенні типів");
            Console.WriteLine("✓ Один клас для різних типів даних");
            Console.WriteLine("✓ Краща продуктивність (без boxing/unboxing)");
        }
    }
}