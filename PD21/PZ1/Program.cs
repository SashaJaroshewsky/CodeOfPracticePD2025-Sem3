namespace PZ1
{
    public class Program
    {
        // Точка входу в програму. Виконується першою.
        static void Main()
        {
            // Виводить текст у консоль з переходом на новий рядок
            Console.WriteLine("WriteLine");

            // Виводить текст у консоль без переходу на новий рядок
            Console.Write("Write");

            // Знову виводить текст з переходом на новий рядок
            Console.WriteLine("WriteLine");

            // Змінна типу int (ціле число)
            int number = 42;

            // Постфіксний інкремент: спочатку використовується значення, потім збільшується на 1
            number++;

            // Префіксний інкремент: спочатку збільшується на 1, потім використовується
            ++number;

            // Постфіксний декремент: спочатку використовується значення, потім зменшується на 1
            number--;

            // Префіксний декремент: спочатку зменшується на 1, потім використовується
            --number;

            // Додавання числа через звичайний запис
            number = number + 5;

            // Додавання числа через скорочений запис (те саме що вище)
            number += 5;

            // Умова if-else
            if (!true) // !true = false
            {
            }
            else if (true) 
            {
            }
            else 
            {
            }

            // Конструкція switch для перевірки значення змінної
            switch (number)
            {
                case 1:
                    break; // Якщо number == 1
                case 2:
                    break; // Якщо number == 2
                default:
                    break; // Якщо number має будь-яке інше значення
            }

            // Приклади використання різних числових типів
            int a = 10;        // ціле число
            float b = 20.5f;   // число з плаваючою комою (менш точне)
            decimal c = 30.5m; // число з високою точністю (для грошей)

            // Неявне перетворення (int -> float)
            b = a;

            // Явне перетворення (float -> int), дробова частина відкидається
            a = (int)b;

            // Одновимірний масив
            int[] array = new int[5]; // масив на 5 елементів
            for (int i = 0; i < array.Length; i++) // цикл від 0 до довжини масиву - 1
            {
                array[i] = i * 10; // заповнюємо масив значеннями 0, 10, 20, 30, 40
            }

            // Двовимірний масив (матриця 5х5)
            int[,] array2 = new int[5, 5];
            for (int i = 0; i < array2.GetLength(0); i++) // перший індекс
            {
                for (int j = 0; j < array2.GetLength(1); j++) // другий індекс
                {
                    array2[i, j] = i * j; // елемент = добуток індексів
                }
            }

            // Зубчастий масив (масив масивів)
            int[][] jaggedArray = new int[3][]; // створюємо масив з 3 елементів
            jaggedArray[0] = new int[] { 1 };          // перший елемент містить масив з 1 числа
            jaggedArray[1] = new int[] { 1, 2 };       // другий – масив з 2 чисел
            jaggedArray[2] = new int[] { 1, 2, 3 };    // третій – масив з 3 чисел

            // Альтернативний спосіб ініціалізації зубчастого масиву 
            // for (int i = 0; i < jaggedArray.Length; i++)
            // {
            //     jaggedArray[i] = new int[i + 1]; // створюємо масив довжиною i+1
            //     for (int j = 0; j < jaggedArray[i].Length; j++)
            //     {
            //         jaggedArray[i][j] = i + j; // заповнюємо числами
            //     }
            // }

            // Виклик методів
            Method(); // виклик методу без параметрів

            int result;
            result = Method2(); // виклик методу, який повертає int

            Method3(result, "Hello"); // виклик методу з параметрами
        }

        // Метод без параметрів і без повернення значення
        private static void Method()
        {
            int a = 10;
            int b = 20;
            if (a>b)
            {
                Console.WriteLine("True"); // виведе "True"
                return; // завершення виконання методу
            }
            Console.WriteLine("False");

            Console.WriteLine("Method");
            return;
        }

        // Метод, який повертає int
        private static int Method2()
        {
            return 42; // завжди повертає число 42
        }

        // Перевантажений метод, який приймає int і повертає його
        private static int Method2(int a)
        {
            return a; 
        }

        // Метод з параметрами і без повернення значення
        private static void Method3(int param1, string param2)
        {
            // Інтерполяція рядка: підставляємо значення змінних у рядок
            Console.WriteLine($"Method3: {param1}, {param2}");
        }

        private static int Method4(int param1, string param2)
        {
            return param1;
        }

    }
}
