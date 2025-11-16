/// <summary>
/// Дженерік колекції (Generic Collections)
/// 
/// .NET надає багато готових дженерік колекцій в просторі імен System.Collections.Generic
/// Вони є типобезпечними та ефективнішими за не-дженерік версії.
/// 
/// ОСНОВНІ ДЖЕНЕРІК КОЛЕКЦІЇ:
/// List<T>           - динамічний масив (найпопулярніша колекція)
/// Dictionary<TKey, TValue> - колекція пар ключ-значення
/// Queue<T>          - черга (FIFO - First In, First Out)
/// Stack<T>          - стек (LIFO - Last In, First Out)
/// HashSet<T>        - колекція унікальних елементів
/// LinkedList<T>     - двозв'язний список
/// 
/// ЧОМУ ВИКОРИСТОВУВАТИ ДЖЕНЕРІК КОЛЕКЦІЇ?
/// - Типобезпека під час компіляції
/// - Не потрібно приведення типів
/// - Краща продуктивність
/// - Сучасний стандарт в C#
/// </summary>
namespace GenericsLearning
{
    // Клас студента для прикладів
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Student(Id: {Id}, Name: {Name}, Age: {Age})";
        }
    }

    public class GenericCollectionsExample
    {
        // === 1. LIST<T> - Динамічний масив ===
        // Найчастіше використовувана колекція
        public void ListExample()
        {
            Console.WriteLine("=== List<T> - Динамічний масив ===");

            // Створення порожнього списку
            List<int> numbers = new List<int>();

            // Додавання елементів
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            Console.WriteLine($"Після Add: {string.Join(", ", numbers)}");

            // Додавання кількох елементів
            numbers.AddRange(new[] { 40, 50 });
            Console.WriteLine($"Після AddRange: {string.Join(", ", numbers)}");

            // Доступ за індексом
            Console.WriteLine($"Елемент з індексом 2: {numbers[2]}");

            // Вставка на конкретну позицію
            numbers.Insert(0, 5); // Вставити 5 на початок
            Console.WriteLine($"Після Insert: {string.Join(", ", numbers)}");

            // Видалення
            numbers.Remove(20); // Видалити перше входження 20
            Console.WriteLine($"Після Remove: {string.Join(", ", numbers)}");

            // Пошук
            bool contains = numbers.Contains(30);
            Console.WriteLine($"Містить 30? {contains}");

            int index = numbers.IndexOf(30);
            Console.WriteLine($"Індекс елемента 30: {index}");

            // Кількість елементів
            Console.WriteLine($"Кількість елементів: {numbers.Count}");

            // Сортування
            numbers.Sort();
            Console.WriteLine($"Після Sort: {string.Join(", ", numbers)}");

            Console.WriteLine();
        }

        // === 2. DICTIONARY<TKey, TValue> - Словник ===
        // Колекція пар ключ-значення для швидкого пошуку
        public void DictionaryExample()
        {
            Console.WriteLine("=== Dictionary<TKey, TValue> - Словник ===");

            // Створення словника (ключ - ID студента, значення - ім'я)
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Додавання елементів
            students.Add(1, "Іван");
            students.Add(2, "Марія");
            students.Add(3, "Петро");

            // Альтернативний спосіб додавання
            students[4] = "Ольга";

            // Доступ за ключем
            Console.WriteLine($"Студент з ID 2: {students[2]}");

            // Безпечний доступ (якщо ключ може не існувати)
            if (students.TryGetValue(3, out string name))
            {
                Console.WriteLine($"Знайдено: {name}");
            }

            // Перевірка існування ключа
            bool hasKey = students.ContainsKey(5);
            Console.WriteLine($"Існує студент з ID 5? {hasKey}");

            // Перевірка існування значення
            bool hasValue = students.ContainsValue("Іван");
            Console.WriteLine($"Існує студент з ім'ям Іван? {hasValue}");

            // Перебір елементів
            Console.WriteLine("Всі студенти:");
            foreach (var kvp in students)
            {
                Console.WriteLine($"  ID {kvp.Key}: {kvp.Value}");
            }

            // Видалення
            students.Remove(1);
            Console.WriteLine($"Після видалення ID 1: {students.Count} студентів");

            Console.WriteLine();
        }

        // === 3. QUEUE<T> - Черга (FIFO) ===
        // Перший зайшов - перший вийшов
        public void QueueExample()
        {
            Console.WriteLine("=== Queue<T> - Черга (FIFO) ===");

            Queue<string> queue = new Queue<string>();

            // Enqueue - додати в кінець черги
            queue.Enqueue("Перший");
            queue.Enqueue("Другий");
            queue.Enqueue("Третій");
            Console.WriteLine($"В черзі: {queue.Count} елементів");

            // Peek - подивитись перший елемент без видалення
            string first = queue.Peek();
            Console.WriteLine($"Перший в черзі (Peek): {first}");
            Console.WriteLine($"Після Peek в черзі: {queue.Count} елементів");

            // Dequeue - взяти та видалити перший елемент
            string removed = queue.Dequeue();
            Console.WriteLine($"Видалено з черги (Dequeue): {removed}");
            Console.WriteLine($"Після Dequeue в черзі: {queue.Count} елементів");

            // Приклад обробки черги
            Console.WriteLine("Обробка всієї черги:");
            while (queue.Count > 0)
            {
                Console.WriteLine($"  Обробка: {queue.Dequeue()}");
            }

            Console.WriteLine();
        }

        // === 4. STACK<T> - Стек (LIFO) ===
        // Останній зайшов - перший вийшов
        public void StackExample()
        {
            Console.WriteLine("=== Stack<T> - Стек (LIFO) ===");

            Stack<string> stack = new Stack<string>();

            // Push - додати на верх стека
            stack.Push("Перший");
            stack.Push("Другий");
            stack.Push("Третій");
            Console.WriteLine($"В стеку: {stack.Count} елементів");

            // Peek - подивитись верхній елемент без видалення
            string top = stack.Peek();
            Console.WriteLine($"Верхній елемент (Peek): {top}");

            // Pop - взяти та видалити верхній елемент
            string removed = stack.Pop();
            Console.WriteLine($"Видалено зі стека (Pop): {removed}");
            Console.WriteLine($"Після Pop в стеку: {stack.Count} елементів");

            // Приклад: перевірка дужок
            Console.WriteLine("\nПриклад: перевірка збалансованості дужок");
            bool isBalanced = CheckBalancedBrackets("({[]})");
            Console.WriteLine($"'({{[]}})' збалансовано? {isBalanced}");

            isBalanced = CheckBalancedBrackets("({[})");
            Console.WriteLine($"'({{[}})' збалансовано? {isBalanced}");

            Console.WriteLine();
        }

        // Допоміжний метод для перевірки збалансованості дужок
        private bool CheckBalancedBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        // === 5. HASHSET<T> - Множина унікальних елементів ===
        // Автоматично видаляє дублікати
        public void HashSetExample()
        {
            Console.WriteLine("=== HashSet<T> - Множина унікальних елементів ===");

            HashSet<int> numbers = new HashSet<int>();

            // Додавання елементів
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(2); // Дублікат - не буде доданий
            numbers.Add(1); // Дублікат - не буде доданий

            Console.WriteLine($"Елементи: {string.Join(", ", numbers)}");
            Console.WriteLine($"Кількість унікальних: {numbers.Count}");

            // Операції над множинами
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

            // Об'єднання (union)
            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2);
            Console.WriteLine($"Об'єднання: {string.Join(", ", union)}");

            // Перетин (intersection)
            HashSet<int> intersection = new HashSet<int>(set1);
            intersection.IntersectWith(set2);
            Console.WriteLine($"Перетин: {string.Join(", ", intersection)}");

            // Різниця
            HashSet<int> difference = new HashSet<int>(set1);
            difference.ExceptWith(set2);
            Console.WriteLine($"Різниця (set1 - set2): {string.Join(", ", difference)}");

            Console.WriteLine();
        }

        // === 6. Робота зі складними об'єктами ===
        public void ComplexObjectsExample()
        {
            Console.WriteLine("=== Робота зі складними об'єктами ===");

            // List з об'єктами Student
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Іван", Age = 20 },
                new Student { Id = 2, Name = "Марія", Age = 19 },
                new Student { Id = 3, Name = "Петро", Age = 21 }
            };

            Console.WriteLine("Список студентів:");
            foreach (var student in students)
            {
                Console.WriteLine($"  {student}");
            }

            // LINQ запити
            var youngStudents = students.Where(s => s.Age < 21).ToList();
            Console.WriteLine("\nСтуденти молодші 21:");
            foreach (var student in youngStudents)
            {
                Console.WriteLine($"  {student.Name}, {student.Age} років");
            }

            // Dictionary зі складними об'єктами
            Dictionary<int, Student> studentDict = new Dictionary<int, Student>();
            foreach (var student in students)
            {
                studentDict[student.Id] = student;
            }

            Console.WriteLine("\nПошук студента з ID 2:");
            if (studentDict.TryGetValue(2, out Student found))
            {
                Console.WriteLine($"  {found}");
            }
        }
    }

    // Клас для демонстрації
    public class GenericCollectionsDemo
    {
        public static void RunExamples()
        {
            var examples = new GenericCollectionsExample();

            examples.ListExample();
            examples.DictionaryExample();
            examples.QueueExample();
            examples.StackExample();
            examples.HashSetExample();
            examples.ComplexObjectsExample();

            Console.WriteLine("=== Коли що використовувати? ===");
            Console.WriteLine("List<T>       - коли потрібен динамічний масив з доступом за індексом");
            Console.WriteLine("Dictionary    - коли потрібен швидкий пошук за ключем");
            Console.WriteLine("Queue<T>      - коли потрібна черга (FIFO), наприклад обробка задач");
            Console.WriteLine("Stack<T>      - коли потрібен стек (LIFO), наприклад відміна дій");
            Console.WriteLine("HashSet<T>    - коли потрібні лише унікальні елементи");
        }
    }
}