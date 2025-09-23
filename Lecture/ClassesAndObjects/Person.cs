using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        // PUBLIC поле - доступне для прямої зміни (не рекомендується)
        public int Age;

        // PRIVATE поле для зберігання імені
        private string _name;

        // ВЛАСТИВІСТЬ з логікою валідації
        // Демонструє ІНКАПСУЛЯЦІЮ - контроль доступу до даних
        public string Name
        {
            get // Getter - повертає значення
            {
                return _name;
            }
            set // Setter - встановлює значення з перевіркою
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Ім'я не може бути пустим");
                else if (value.Length < 2)
                    Console.WriteLine("Ім'я не може бути меншим за 2 символи");
                else
                    _name = value;
            }
        }

        // КОНСТРУКТОР з параметрами
        public Person(string name, int age)
        {
            _name = name; // Пряме присвоєння до поля (минаючи валідацію)
            Age = age;
        }
    }
}
