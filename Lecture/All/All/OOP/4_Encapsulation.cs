using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 4. Encapsulation — Інкапсуляція
    /// 
    /// ТЕОРІЯ:
    /// Інкапсуляція — приховування внутрішньої реалізації та даних
    /// 
    /// МОДИФІКАТОРИ ДОСТУПУ:
    /// public — доступний звідусіль
    /// private — доступний тільки всередині класу (за замовчуванням)
    /// protected — доступний в класі та похідних класах
    /// internal — доступний в межах поточної збірки (assembly)
    /// protected internal — поєднання protected і internal
    /// 
    /// ПРИНЦИП:
    /// - Поля — private
    /// - Властивості та методи — public
    /// - Приховування деталей реалізації
    /// </summary>
    public class Encapsulation
    {
        public class CoffeeMachine
        {
            // Приватні поля — приховані від зовнішнього світу
            private int waterLevel;
            private int coffeeLevel;
            private bool isOn;

            // Публічні властивості з контрольованим доступом
            public int WaterLevel
            {
                get { return waterLevel; }
                private set { waterLevel = value; }  // Тільки клас може змінювати
            }

            public int CoffeeLevel
            {
                get { return coffeeLevel; }
                private set { coffeeLevel = value; }
            }

            public bool IsOn
            {
                get { return isOn; }
            }

            // Константи
            private const int MAX_WATER = 1000;
            private const int MAX_COFFEE = 500;
            private const int COFFEE_PER_CUP = 10;
            private const int WATER_PER_CUP = 100;

            // Конструктор
            public CoffeeMachine()
            {
                waterLevel = MAX_WATER;
                coffeeLevel = MAX_COFFEE;
                isOn = false;
            }

            // Публічні методи — інтерфейс взаємодії
            public void TurnOn()
            {
                if (!isOn)
                {
                    isOn = true;
                    Console.WriteLine("☕ Кавоварка увімкнена");
                    ShowStatus();
                }
            }

            public void TurnOff()
            {
                if (isOn)
                {
                    isOn = false;
                    Console.WriteLine("☕ Кавоварка вимкнена");
                }
            }

            public void MakeCoffee()
            {
                if (!isOn)
                {
                    Console.WriteLine("❌ Спочатку увімкніть кавоварку!");
                    return;
                }

                if (!CheckResources())
                {
                    Console.WriteLine("❌ Недостатньо ресурсів!");
                    ShowStatus();
                    return;
                }

                // Використовуємо приватний метод
                BrewCoffee();
            }

            public void Refill()
            {
                waterLevel = MAX_WATER;
                coffeeLevel = MAX_COFFEE;
                Console.WriteLine("✅ Ресурси поповнені");
                ShowStatus();
            }

            public void ShowStatus()
            {
                Console.WriteLine($"💧 Вода: {waterLevel}/{MAX_WATER} мл");
                Console.WriteLine($"☕ Кава: {coffeeLevel}/{MAX_COFFEE} г");
            }

            // Приватні методи — внутрішня логіка (приховані)
            private bool CheckResources()
            {
                return waterLevel >= WATER_PER_CUP && coffeeLevel >= COFFEE_PER_CUP;
            }

            private void BrewCoffee()
            {
                Console.WriteLine("☕ Готую каву...");

                // Симуляція процесу
                System.Threading.Thread.Sleep(1000);
                HeatWater();
                System.Threading.Thread.Sleep(500);
                GrindCoffee();
                System.Threading.Thread.Sleep(500);
                PourCoffee();

                // Зменшуємо ресурси
                waterLevel -= WATER_PER_CUP;
                coffeeLevel -= COFFEE_PER_CUP;

                Console.WriteLine("✅ Кава готова! Смачного!");
                ShowStatus();
            }

            private void HeatWater()
            {
                Console.WriteLine("  🔥 Підігрів води...");
            }

            private void GrindCoffee()
            {
                Console.WriteLine("  ⚙️ Помел кави...");
            }

            private void PourCoffee()
            {
                Console.WriteLine("  💧 Наливаю каву...");
            }
        }

        public static void DemonstrateEncapsulation()
        {
            Console.WriteLine("=== ІНКАПСУЛЯЦІЯ ===\n");

            CoffeeMachine machine = new CoffeeMachine();

            // Користувач бачить тільки публічний інтерфейс
            machine.TurnOn();

            Console.WriteLine();
            machine.MakeCoffee();

            Console.WriteLine();
            machine.MakeCoffee();

            // Не можемо прямо змінити waterLevel або coffeeLevel
            // machine.waterLevel = 0; // ПОМИЛКА! Приватне поле

            Console.WriteLine();
            machine.Refill();

            Console.WriteLine();
            machine.TurnOff();

            Console.WriteLine("\n📝 ІНКАПСУЛЯЦІЯ:");
            Console.WriteLine("✓ Приховує складну внутрішню логіку");
            Console.WriteLine("✓ Захищає дані від некоректної зміни");
            Console.WriteLine("✓ Надає простий інтерфейс користування");
        }
    }
}
