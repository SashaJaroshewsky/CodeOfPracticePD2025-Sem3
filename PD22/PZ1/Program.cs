namespace PZ1
{
    class Program
    {
        // Точка входу в програму. Починається виконання саме з Main
        static void Main(string[] args)
        {
            // Виведення в консоль з переходом на новий рядок
            Console.WriteLine("WriteLine");

            // Виведення без переходу на новий рядок
            Console.Write("Write");

            // Знову виведення з переходом
            Console.WriteLine("WriteLine");

            // Оголошення змінних
            int a = 0;
            string b = "Hello";

            // Копіюємо значення змінної a у c
            int c = a;

            // Різні способи збільшити значення змінної на 1
            c++;      // постфіксний інкремент
            c = c + 1; // звичайне додавання
            c += 1;   // скорочений запис додавання

            // Виведення значення змінної a (залишилось 0, бо змінювали c, а не a)
            Console.WriteLine(a);

            // Оператор остачі від ділення (3 % 2 = 1)
            Console.WriteLine(3 % 2);

            // Логічне заперечення. !true = false
            if (!true) { }

            // Робота з діленням
            int e = 5;
            e /= 3;    // скорочений запис ділення
            e = e / 3; // звичайний запис ділення

            // Приклад роботи з різними числовими типами
            int coin = 0; //Ціле число
            float money = 0.0f; //Дробове число; мала точність
            double money2 = 0.0f;//Дробове число; велика точність (для грошей)
            

            // Неявне перетворення (int → float)
            money = coin;

            // Явне перетворення (float → int)
            coin = (int)money;

            // Умовні оператори
            if (2 > 5) { }
            else if (5 > 3) { }
            else { }

            // Тернарний оператор: якщо 2 > 4 (ні), то 1, інакше 2
            int max = (2 > 4) ? 1 : 2;

            // Конструкція switch
            switch (max)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            // Масиви
            int[] arr = new int[4];     // одновимірний масив на 4 елементи
            int[,] arr2 = new int[4, 3]; // двовимірний масив 4x3

            // Генератор випадкових чисел
            Random rand = new Random();
            rand.Next(0, 10); // згенерує число від 0 до 9

            // Зубчастий масив (масив масивів)
            int[][] arr3 = new int[3][];
            arr3[0] = new int[2]; // масив довжини 2
            arr3[1] = new int[3]; // масив довжини 3
            arr3[2] = new int[4]; // масив довжини 4

            // Довжина одновимірного масиву
            int Length = arr.Length;

            // Цикл foreach для проходу по масиву
            foreach (int item in arr)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("+++++++++++");

            // Зчитування рядка з консолі 
            //string name = Console.ReadLine();
            //Console.WriteLine(name);

            // Виклик методів
            Func0(); // метод без параметрів
                     //Func1(); // не можна викликати без параметрів, бо у нього out

            // Виклик методу, який повертає bool
            bool result = Func2();
            result = Func2(); // повторний виклик

            if (Func2()) { } // можна викликати прямо в if

            // Виклик методу з параметрами
            var res2 = Func3(1, 2);

            // Використання object: може містити будь-який тип
            object obj = "strs;lethj;di"; // рядок
            obj = 2;   // тепер int
            obj = 3f;  // тепер float
            Console.WriteLine("+++++++++++++++");

            // Робота з out-параметрами
            int t = 30;
            Func1(out t, out int t2); // метод змінює значення t і створює t2

            if (Func1(out t, out t2)) // якщо повернув true
            {
                t = t + 10;
            }
            else
            {
                t = 0;
            }

            Console.WriteLine($"{t} {t2}"); // інтерполяція рядка
            Console.WriteLine(t);

            // Виклик перевантажених методів
            Func2();
            Func2("sugar");

            // Спроба зчитати число з консолі
            if (int.TryParse(Console.ReadLine(), out int enterage))
                Console.WriteLine(enterage); // якщо вдалося
            else
                Console.WriteLine("Error");  // якщо не вдалося
        }

        // Метод з out-параметрами
        private static bool Func1(out int a, out int b)
        {
            a = Random.Shared.Next(0, 10); // випадкове число від 0 до 9
            b = Random.Shared.Next(0, 10);

            if (a > b) return true;
            else return false;
        }

        // Метод без параметрів і повернення значення
        private static void Func0()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++");
            Console.WriteLine();
        }

        // Метод, який повертає true
        private static bool Func2()
        {
            int a = 0;
            return true;
        }

        // Перевантажений метод Func2 з параметром
        private static bool Func2(string sugar)
        {
            int a = 0;
            return true;
        }

        // Метод з двома параметрами і поверненням значення
        private static int Func3(int a, int b)
        {
            return a; 
        }
    }
}
