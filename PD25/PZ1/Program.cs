namespace PZ1
{
    public class Program
    {
        // Метод Main – точка входу в програму
        static void Main()
        {
            // Виведення рядка з переходом на новий рядок
            Console.WriteLine("WriteLine");

            // Виведення без переходу на новий рядок
            Console.Write("Write");

            // Знову виведення з переходом
            Console.WriteLine("WriteLine");

            //Console.ReadLine(); // очікування вводу з клавіатури

            // --- ЗМІННІ ТА ОПЕРАТОРИ ---

            int a = 5; // Змінна типу int (ціле число)
            int b = 10;

            // Оператор остачі від ділення (%). 3 % 2 = 1
            Console.WriteLine(3 % 2);

            // Логічні оператори OR (||). Виконується, якщо хоча б одна умова true
            if (a > b || b > a)
            {
                
            }

            int c = 15;
            c = c + 2; // звичайне додавання
            c += 2;    // скорочений запис додавання

            c++; // постфіксний інкремент (спочатку використати, потім збільшити)
            c--; // постфіксний декремент
            ++c; // префіксний інкремент (спочатку збільшити, потім використати)
            --c; // префіксний декремент

            c = 0;
            Console.WriteLine("++++++++++++++");

            // Виведе 0, а потім збільшить c до 1
            Console.WriteLine(c++);

            // Спочатку збільшить c (тепер 2), потім виведе його
            Console.WriteLine(++c);

            c /= 1; // поділити на 1 (залишиться тим самим)
            c = c + 1;

            // --- ПЕРЕТВОРЕННЯ ТИПІВ ---

            int coin = 5;
            decimal money = 0.0m; // m вказує, що це decimal
            money = coin;         // неявне перетворення int → decimal

            coin = (int)money;    // явне перетворення decimal → int

            object obj = coin;    // boxing: int зберігається як object
            int coin2 = (int)obj; // unboxing: object → int

            Console.WriteLine(obj);

            // --- IF / ELSE ---
            if (false) { }
            else if (false) { }
            else { }

            // --- SWITCH ---
            switch (coin)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            // Тернарний оператор (умовний вираз)
            string flag = (coin < money) ? "good" : "fgj";

            // --- МАСИВИ ---

            Console.WriteLine("++++++++++++++++");
            int[] arr = new int[5]; // одновимірний масив
            int index = 0;
            Random random = new Random(); // генератор випадкових чисел

            // Заповнюємо масив випадковими числами
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10); // випадкове число від 0 до 9
                Console.WriteLine($"{nameof(arr)}[{i}] = {arr[i]}");
            }

           

            // --- ДВОМІРНИЙ МАСИВ ---
            Console.WriteLine("+++++++++++++++++");
            int[,] arr2 = new int[4, 4]; // квадратна матриця 4x4

            for (int i = 0; i < arr2.GetLength(0); i++) // кількість рядків
            {
                for (int j = 0; j < arr2.GetLength(1); j++) // кількість стовпців
                {
                    arr2[i, j] = random.Next(0, 10);
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }

            // Виведення лише діагоналі масиву
            Console.WriteLine("+++++++++++++++");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (i == j) // умова для головної діагоналі
                    {
                        Console.Write($"{arr2[i, i]} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            // --- ЗУБЧАСТИЙ МАСИВ ---
            int[][] arr3 = new int[3][]; // jagged array (масив масивів)
            arr3[0] = new int[5];
            arr3[1] = new int[3];
            arr3[2] = new int[4];

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    arr3[i][j] = random.Next(0, 10);
                    Console.Write($"{arr3[i][j]} ");
                }
                Console.WriteLine();
            }

            // --- МЕТОДИ ТА ПАРАМЕТРИ ---
            Console.WriteLine("+++++++++++++++++++++");
            int number = 0;

            Method();           // виклик методу без параметрів
            Method(ref number); // ref: змінна передається "за посиланням"
            Console.WriteLine(number);

            Method2(out int number2); // out: змінна обов'язково має бути присвоєна в методі

            Console.WriteLine("================");
            Method2();      // повертає int
            Method2(10);    // перевантажений метод з параметром

            // --- РОБОТА З ВВОДОМ КОРИСТУВАЧА ---
            Console.WriteLine("++++++++++++++++++++");

            string input = Console.ReadLine(); // читає рядок з консолі
            Console.WriteLine(input);

            // Спроба перетворення рядка у число
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine(result); // якщо вдалося
            }
            else
            {
                Console.WriteLine("Error"); // якщо не вдалося
            }
        }

        // Метод без параметрів
        public static void Method()
        {
            Console.WriteLine("Hi");
        }

        // Метод з ref-параметром: змінна змінюється прямо у викликаючому коді
        public static void Method(ref int a)
        {
            a++;
            Console.WriteLine(a);
        }

        // Метод з out-параметром: змінна ініціалізується в середині методу
        public static void Method2(out int a)
        {
            if (true)
                a = 1; // обов'язково треба щось присвоїти

            a = 0;
            Console.WriteLine(a);
        }

        // Метод, який повертає число
        public static int Method2()
        {
            return 5;
        }

        // Перевантажений метод Method2 з параметром
        public static int Method2(int a)
        {
            return a;
        }
    }
}
