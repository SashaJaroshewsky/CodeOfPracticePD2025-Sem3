namespace PZ1
{
    class Program
    {
        // Точка входу в програму
        static void Main()
        {
            // ===== Вивід у консоль =====
            Console.WriteLine("WriteLine");  // Вивід із переходом на новий рядок
            Console.Write("Write");          // Вивід без переходу
            Console.WriteLine("WriteLine");  // Знову з переходом

            // Оператор % — остача від ділення. 3 % 1 = 0 (3 ділиться на 1 без остачі)
            Console.WriteLine(3 % 1);

            // Логічне заперечення: !true = false. Тіло if не виконається
            if (!true) { }

            // ===== Змінні та приведення типів =====
            int a = 5;       // ціле число (32 біти)
            float b = 3.5f;  // число з плаваючою комою (32 біти)
            double c = 4.5;  // число з плаваючою комою (64 біти)
            decimal d = 5.5m; // число з плаваючою комою (128 біт) для фінансових розрахунків

            // Неявне перетворення: int → float (не втрачає точність, дозволено автоматично)
            b = a;

            // Явне перетворення: float → int (дробова частина відкидається, потрібен каст)
            a = (int)b;

            // ===== Інкременти та арифметика =====
            a++;      // постфіксний інкремент (збільшити на 1)
            a = a + 1; // звичайне додавання
            a += 3;   // скорочений запис (додати 3)

            // Object — базовий тип усіх класів у .NET.
            // Може містити будь-яке значення: число, рядок, масив, інший об'єкт.
            object obj = a;

            // ===== Умовні оператори =====
            if (true) { }
            else if (false) { }

            // Тернарний оператор: (умова ? якщо true : якщо false)
            bool flag = (a > b) ? true : false;

            // Конструкція switch для перевірки значення змінної
            switch (a)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break; // якщо жоден case не підійшов
            }

            // ===== Масиви =====

            // Одновимірний масив на 5 елементів. За замовчуванням усі елементи = 0
            int[] arr = new int[5]; // індекси 0..4

            // Заповнення масиву: arr[i] = i
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            // Ініціалізація масиву одразу зі значеннями
            int[] arr2 = { 0, 1, 2, 3, 4 };

            // Двовимірний масив (матриця 3x4: 3 рядки, 4 колонки)
            int[,] arr3 = new int[3, 4];

            // Зубчастий масив (масив масивів різної довжини)
            int[][] arr4 = new int[3][];
            arr4[0] = new int[2];
            arr4[1] = new int[3];
            arr4[2] = new int[4];

            // foreach — цикл для перебору елементів у колекції
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("+++++++++++++++++++++++++++");

            // ===== Виклик методів (перевантаження) =====
            MakeTea(1);                  // метод з int
            MakeTea("Sugar");            // метод з string
            MakeTea("Sugar", "Mint");    // метод з двома string

            // ===== ref-параметри =====
            int counter = 0;
            Console.WriteLine(counter);   // 0
            AddOne(ref counter);          // ref передає змінну "за посиланням"
            Console.WriteLine(counter);   // 1

            // ===== out-параметри =====
            if (ChekPositive(counter, out string counter1))
            {
                Console.WriteLine(counter1); // "Positive"
            }

            // Виклик методу з різними типами параметрів
            int gg = Method4(1, 4.5f);

            // ===== Робота з введенням =====
            string input = Console.ReadLine(); // зчитування з консолі

            // int.TryParse намагається перетворити рядок у число
            // Повертає true/false, і якщо успіх — результат записується в out-параметр
            if (int.TryParse(input, out int num))
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        // Метод із out-параметром
        // out — означає, що значення буде присвоєне всередині методу і повернене назовні
        public static bool ChekPositive(int number, out string a)
        {
            if (number >= 0)
            {
                a = "Positive";
                return true;
            }
            a = "Non-Positive";
            return false;
        }

        // ref — передає змінну за посиланням. Її можна змінити прямо в методі
        public static void AddOne(ref int a)
        {
            a++;
        }

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        // ===== Перевантаження методів =====
        // Перевантаження — це коли методи мають однакову назву, але різні параметри

        public static void MakeTea(int a)
        {
            Console.WriteLine(a);
        }

        public static void MakeTea(float a)
        {
            Console.WriteLine(a);
        }

        public static void MakeTea(string ingredient)
        {
            if (ingredient == "Sugar")
            {
                Console.WriteLine("Sweet");
                return;
            }
            Console.WriteLine("Not Sugar");
        }

        public static void MakeTea(string ingredient, string ingredient2)
        {
            if (ingredient == "Sugar" && ingredient2 == "Mint")
            {
                Console.WriteLine("Sweet and fresh");
                return;
            }
            else if (ingredient == "Sugar")
            {
                Console.WriteLine("Sweet");
                return;
            }
            Console.WriteLine("Not Sweet");
        }

        // Метод, який повертає рядок (читає введення з консолі)
        public static string Method3()
        {
            return Console.ReadLine();
        }

        // Метод із параметрами різних типів
        public static int Method4(int a, float b)
        {
            return a + (int)b; // float → int (відкидає дробову частину)
        }
    }
}
