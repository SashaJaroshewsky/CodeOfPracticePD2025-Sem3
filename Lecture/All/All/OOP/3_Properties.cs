using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 3. Properties — Властивості
    /// 
    /// ТЕОРІЯ:
    /// Властивість (Property) — член класу, що надає контрольований доступ до поля
    /// 
    /// ПЕРЕВАГИ над публічними полями:
    /// - Валідація даних
    /// - Обчислювані значення
    /// - Інкапсуляція
    /// - Можна додати логіку пізніше без зміни інтерфейсу
    /// 
    /// ВИДИ:
    /// - Повна властивість з get/set
    /// - Автовластивість (auto-property)
    /// - Тільки для читання (get only)
    /// - init (C# 9+) — можна встановити тільки при ініціалізації
    /// </summary>
    public class Properties
    {
        public class BankAccount
        {
            // Приватне поле
            private decimal balance;

            // Повна властивість з валідацією
            public decimal Balance
            {
                get
                {
                    return balance;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Баланс не може бути від'ємним!");
                        return;
                    }
                    balance = value;
                }
            }

            // Автовластивість (auto-property) — компілятор створює приховане поле
            public string AccountNumber { get; set; }
            public string Owner { get; set; }

            // Властивість тільки для читання (readonly)
            public DateTime CreatedDate { get; }

            // Обчислювана властивість (computed property)
            public string AccountInfo
            {
                get { return $"{Owner} - {AccountNumber}"; }
            }

            // Властивість з різними рівнями доступу
            public decimal Interest { get; private set; }

            // Конструктор
            public BankAccount(string owner, string accountNumber, decimal initialBalance)
            {
                Owner = owner;
                AccountNumber = accountNumber;
                Balance = initialBalance;  // Використовує setter з валідацією
                CreatedDate = DateTime.Now;
                Interest = 0.05m;  // 5%
            }

            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Поповнено: {amount:C}. Баланс: {Balance:C}");
                }
            }

            public void Withdraw(decimal amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Знято: {amount:C}. Баланс: {Balance:C}");
                }
                else
                {
                    Console.WriteLine("Недостатньо коштів!");
                }
            }
        }

        // Клас з init (C# 9+)
        public class Person
        {
            // init — можна встановити тільки при створенні об'єкта або в конструкторі
            public string FirstName { get; init; }
            public string LastName { get; init; }

            // Звичайна властивість
            public int Age { get; set; }

            // Обчислювана властивість
            public string FullName => $"{FirstName} {LastName}";

            // Властивість з виразом (expression-bodied)
            public bool IsAdult => Age >= 18;
        }

        public static void DemonstrateProperties()
        {
            Console.WriteLine("=== ВЛАСТИВОСТІ ===\n");

            // Створення банківського рахунку
            BankAccount account = new BankAccount("Іван Петренко", "UA123456", 1000m);

            Console.WriteLine($"Рахунок: {account.AccountInfo}");
            Console.WriteLine($"Баланс: {account.Balance:C}");
            Console.WriteLine($"Створено: {account.CreatedDate:d}");

            // Операції
            account.Deposit(500);
            account.Withdraw(300);
            account.Withdraw(2000);  // Недостатньо коштів

            // Спроба встановити від'ємний баланс
            Console.WriteLine("\nСпроба встановити від'ємний баланс:");
            account.Balance = -100;  // Валідація спрацює!

            Console.WriteLine("\n=== PERSON з init ===\n");

            // Ініціалізація об'єкта
            Person person = new Person
            {
                FirstName = "Марія",
                LastName = "Іванова",
                Age = 25
            };

            Console.WriteLine($"Ім'я: {person.FullName}");
            Console.WriteLine($"Вік: {person.Age}");
            Console.WriteLine($"Повнолітній: {person.IsAdult}");

            // Можна змінити Age
            person.Age = 26;
            Console.WriteLine($"Новий вік: {person.Age}");

            // Не можна змінити FirstName (init)
            //person.FirstName = "Олена"; // ПОМИЛКА компіляції!
        }
    }
}
