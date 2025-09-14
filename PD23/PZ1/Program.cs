namespace PZ1 //Простір імен
{
    // Клас Program – контейнер для методу Main
    // У C# все має бути всередині класу

    class Program
    {
        // Метод Main – точка входу в програму
        static void Main(string[] args)
        {
            // Арифметичні операції
            Console.WriteLine(3 * 2); // множення, результат = 6

            // Оголошення змінних різних типів
            int a = 5;        // int – цілі числа
            float b = 3.2f;   // float – числа з плаваючою комою (4 байти, точність ~7 цифр)
            decimal c = 4.5m; // decimal – точний тип для фінансів (16 байт, точність ~28 цифр)
            double d = 6.7;   // double – числа з плаваючою комою (8 байт, точність ~15 цифр)

            // Неявне перетворення: int → float (без втрати даних)
            b = a;

            // Явне перетворення: float → int (дробова частина відкидається)
            a = (int)b;

            // Інтерполяція рядка: виводимо значення змінної прямо у текст
            Console.WriteLine($"a = {a}");

            // Пошук більшого значення за допомогою if-else
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else if (b > a)
            {
                max = (int)b;
            }

            // Тернарний оператор (короткий запис if-else)
            int g = (a > b) ? max = a : max = (int)b;

            // Конструкція switch – альтернатива if-else для багатьох варіантів
            switch (a)
            {
                case 1:
                    Console.WriteLine("a is 1");
                    break;
                case 2:
                    Console.WriteLine("a is 2");
                    break;
                case 3:
                    Console.WriteLine("a is 3");
                    break;
                default: // якщо не співпало жодне значення
                    Console.WriteLine("a is not 1, 2 or 3");
                    break;
            }

            // Масиви
            int[] arr = { 1, 2, 3, 4, 5 };     // одновимірний масив з 5 елементами
            int[] arr2 = new int[5];           // створення масиву з 5 елементами (усі = 0 за замовчуванням)

            // Клас Random для генерації випадкових чисел
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 10); // записуємо випадкове число від 0 до 9
            }

            // Двовимірний масив (таблиця 3x4)
            int[,] ints = new int[3, 4];

            // Зубчастий масив (масив масивів)
            int[][] jagged = new int[3][];
            jagged[0] = new int[2]; // перший масив довжиною 2
            jagged[1] = new int[3]; // другий довжиною 3
            jagged[2] = new int[4]; // третій довжиною 4

            // Використання ref-параметра
            int a1 = 5;
            Method3(ref a1); // передаємо посилання на змінну
            Console.WriteLine(a1); // значення змінене всередині методу

            // Використання out-параметра
            Method5(out int a2); // метод зобов’язаний присвоїти значення
            a2++;
            Console.WriteLine(a2);

            // Виклик методу, що повертає значення
            int result = Mthod2();

            // Метод з двома параметрами і виразом-тілом
            int result2 = Mthod4(result, b);

            float sugar = 3.5f;

            // Виклики перевантажених методів (Method3 має кілька версій)
            Method3(ref result); // версія для int
            Method3(ref sugar);  // версія для float

            // Зчитування введення користувача
            string input = Console.ReadLine();

            // Перетворення рядка у число (TryParse не викликає помилку, якщо введено не число)
            if (int.TryParse(input, out int resalt))
            {
                Console.WriteLine(++resalt); // префіксний інкремент
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        // Простий метод без параметрів і повернення
        private static void Method1()
        {
            Console.WriteLine("Method1");
        }

        // Метод, що повертає int
        private static int Mthod2()
        {
            return 5;
        }

        // Метод з ref-параметром: дозволяє змінювати змінну з Main
        private static void Method3(ref int a) { a++; }

        // Перевантаження методу (інший тип параметра)
        private static void Method3(ref float a) { a++; }

        // Ще одне перевантаження з in-параметром
        // in означає, що параметр можна лише читати (не змінювати)
        private static void Method3(ref float a, in float b)
        {
            a++;
            // b++; // не можна змінювати, бо він in
        }

        // Метод з out-параметром: обов’язково присвоює значення
        private static void Method5(out int a)
        {
            a = 5;
        }

        // Метод з виразом-тілом (синтаксис "=>")
        // Повертає суму цілого і приведеного до int float
        private static int Mthod4(int a, float b) => (int)b + a;
    }
}
