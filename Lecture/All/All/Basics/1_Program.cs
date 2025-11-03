namespace All.Basics
{
    /// <summary>
    /// 1. SyntaxAndStructure — Базовий синтаксис та структура програми
    /// 
    /// ТЕОРІЯ:
    /// - C# програма складається з класів та методів
    /// - Main() — точка входу в програму (з неї починається виконання)
    /// - Кожна інструкція закінчується крапкою з комою (;)
    /// - Блоки коду оточуються фігурними дужками { }
    /// - Регістр має значення: MyClass та myclass — різні імена
    /// </summary>
    public class Program
    {
        // Метод Main() — тут починається виконання програми
        public static void Main(string[] args)
        {
            // Це однорядковий коментар

            /* Це
               багаторядковий
               коментар */

            Console.WriteLine("Привіт, світ!"); // Виведення тексту

            // Виклик методу
            ShowStructure();
        }

        // Приклад простого методу
        public static void ShowStructure()
        {
            Console.WriteLine("Структура програми C#:");
            Console.WriteLine("- Namespace (простір імен)");
            Console.WriteLine("- Class (клас)");
            Console.WriteLine("- Method (метод)");
        }
    }
}
