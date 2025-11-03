using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 9. CompositionAndAggregation — Зв’язки між класами
    /// 
    /// ТЕОРІЯ:
    /// - Композиція — коли один об’єкт створює і "володіє" іншим (життєвий цикл спільний)
    /// - Агрегація — коли об’єкт лише "посилається" на інший (життєві цикли незалежні)
    /// 
    /// СИНТАКСИС:
    /// Composition: class A { private B _b = new B(); }
    /// Aggregation: class A { private B _b; public A(B b) { _b = b; } }
    /// </summary>
    public class CompositionAndAggregation
    {
        // === КОМПОЗИЦІЯ ===
        public class Engine
        {
            public void Start()
            {
                Console.WriteLine("Двигун запущено 🚗💨");
            }
        }

        public class Car
        {
            private Engine _engine = new Engine(); // створюється всередині — композиція

            public void Drive()
            {
                _engine.Start();
                Console.WriteLine("Автомобіль їде 🚙");
            }
        }

        // === АГРЕГАЦІЯ ===
        public class Teacher
        {
            public string Name { get; }

            public Teacher(string name)
            {
                Name = name;
            }

            public void Teach()
            {
                Console.WriteLine($"{Name} викладає 👩‍🏫");
            }
        }

        public class School
        {
            private Teacher _teacher; // лише посилання — агрегація

            public School(Teacher teacher)
            {
                _teacher = teacher;
            }

            public void StartLesson()
            {
                Console.WriteLine("Урок починається 📚");
                _teacher.Teach();
            }
        }

        public static void DemonstrateRelations()
        {
            Console.WriteLine("=== КОМПОЗИЦІЯ ТА АГРЕГАЦІЯ ===\n");

            Car car = new Car();
            car.Drive();

            Console.WriteLine();

            Teacher teacher = new Teacher("Пан Іваненко");
            School school = new School(teacher);
            school.StartLesson();
        }
    }

}
