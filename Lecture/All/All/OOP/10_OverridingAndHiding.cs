using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 10. OverridingAndHiding — Перевизначення та приховування методів
    /// 
    /// ТЕОРІЯ:
    /// - overriding (override): замінює поведінку базового методу (потрібно virtual у базі)
    /// - hiding (new): приховує базовий метод, але не замінює його (визначається ключовим словом new)
    /// 
    /// ПРИЗНАЧЕННЯ:
    /// override — для розширення поведінки
    /// new — для повного приховування попередньої реалізації
    /// </summary>
    public class OverridingAndHiding
    {
        public class BaseClass
        {
            public virtual void Show()
            {
                Console.WriteLine("Базовий клас: virtual Show()");
            }

            public void Display()
            {
                Console.WriteLine("Базовий клас: Display()");
            }
        }

        public class DerivedClass : BaseClass
        {
            public override void Show()
            {
                Console.WriteLine("Похідний клас: override Show()");
            }

            public new void Display()
            {
                Console.WriteLine("Похідний клас: new Display()");
            }
        }

        public static void DemonstrateOverrideAndHide()
        {
            Console.WriteLine("=== OVERRIDING vs HIDING ===\n");

            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();
            BaseClass polymorphic = new DerivedClass();

            Console.WriteLine("--- Базовий об'єкт ---");
            baseObj.Show();
            baseObj.Display();

            Console.WriteLine("\n--- Похідний об'єкт ---");
            derivedObj.Show();    // override
            derivedObj.Display(); // new

            Console.WriteLine("\n--- Поліморфна змінна ---");
            polymorphic.Show();   // викликає override версію
            polymorphic.Display(); // викликає базову версію, бо new не перевизначає
        }
    }

}
