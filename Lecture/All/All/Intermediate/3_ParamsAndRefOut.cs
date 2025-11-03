using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Intermediate
{
    /// <summary>
    /// 3. ParamsAndRefOut — Параметри params, ref, out
    /// 
    /// ТЕОРІЯ:
    /// params — змінна кількість параметрів одного типу
    /// ref — передача за посиланням (змінна ПОВИННА бути ініціалізована)
    /// out — вихідний параметр (метод ПОВИНЕН присвоїти значення)
    /// 
    /// ЗА ЗАМОВЧУВАННЯМ параметри передаються ЗА ЗНАЧЕННЯМ (копія)
    /// </summary>
    public class ParamsAndRefOut
    {
        // PARAMS — змінна кількість параметрів
        public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        public static void PrintNames(string greeting, params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"{greeting}, {name}!");
            }
        }

        // REF — передача за посиланням (можна змінювати оригінал)
        public static void Increment(ref int number)
        {
            number++;  // Змінює оригінальну змінну!
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // OUT — вихідний параметр (метод повинен присвоїти значення)
        public static void GetMinMax(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];

            foreach (int num in array)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }

        // Метод, який повертає кілька значень через out
        public static bool Divide(int a, int b, out int quotient, out int remainder)
        {
            if (b == 0)
            {
                quotient = 0;
                remainder = 0;
                return false;  // Помилка: ділення на 0
            }

            quotient = a / b;
            remainder = a % b;
            return true;  // Успіх
        }

        public static void DemonstrateParams()
        {
            // PARAMS — будь-яка кількість аргументів
            Console.WriteLine("=== PARAMS ===");
            Console.WriteLine(Sum(1, 2, 3));           // 6
            Console.WriteLine(Sum(10, 20, 30, 40));    // 100
            Console.WriteLine(Sum(5));                 // 5
            Console.WriteLine(Sum());                  // 0

            PrintNames("Привіт", "Іван", "Марія", "Петро");

            // REF — зміна оригінальної змінної
            Console.WriteLine("\n=== REF ===");
            int x = 10;
            Console.WriteLine($"До: x = {x}");
            Increment(ref x);
            Console.WriteLine($"Після: x = {x}");  // 11

            int a = 0, b = 10;
            Console.WriteLine($"До swap: a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Після swap: a={a}, b={b}");

            // OUT — отримання кількох значень
            Console.WriteLine("\n=== OUT ===");
            int[] nums = { 5, 2, 8, 1, 9, 3 };
            GetMinMax(nums, out int min, out int max);
            Console.WriteLine($"Min: {min}, Max: {max}");

            bool success = Divide(17, 5, out int quot, out int rem);
            if (success)
                Console.WriteLine($"17 / 5 = {quot}, остача {rem}");
        }
    }
}
