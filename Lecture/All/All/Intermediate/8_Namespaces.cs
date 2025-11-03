using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace All.Intermediate
{
    /// <summary>
    /// 9. Namespaces — Простори імен
    /// 
    /// ТЕОРІЯ:
    /// Namespace — логічна група класів, структур, інтерфейсів
    /// 
    /// ПЕРЕВАГИ:
    /// - Організація коду
    /// - Уникнення конфліктів імен
    /// - Логічна структура проєкту
    /// 
    /// using — імпорт простору імен
    /// 
    /// ПРИКЛАДИ:
    /// - System
    /// - System.Collections.Generic
    /// - System.IO
    /// - MyCompany.MyProject.MyFeature
    /// </summary>
    public class Namespaces
    {
        // Простори імен вказуються на початку файлу:
        // using System;
        // using System.Collections.Generic;

        public static void DemonstrateNamespaces()
        {
            Console.WriteLine("=== NAMESPACES ===");

            // Без using потрібно вказувати повний шлях
            System.Console.WriteLine("Повний шлях до Console");

            // З using можна писати коротко
            Console.WriteLine("Короткий варіант");

            // Приклад організації
            Console.WriteLine("\nСтруктура namespace:");
            Console.WriteLine("MyCompany.ProjectName.Features.Authentication");
            Console.WriteLine("MyCompany.ProjectName.Features.UserManagement");
            Console.WriteLine("MyCompany.ProjectName.Data.Models");

            // Псевдоніми (alias)
            // using MyAlias = System.Collections.Generic;
            // MyAlias.List<int> numbers = new MyAlias.List<int>();

            Console.WriteLine("\nNamespace допомагає структурувати великі проєкти!");
        }
    }
}
