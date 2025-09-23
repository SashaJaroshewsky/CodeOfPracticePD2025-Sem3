namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЩО ТАКЕ ОБ'ЄКТ (ЕКЗЕМПЛЯР КЛАСУ) ===");
            // ОБ'ЄКТ (ЕКЗЕМПЛЯР) - це конкретна реалізація класу в пам'яті
            // Клас BankAccount - це креслення, а account1 і account2 - це конкретні об'єкти
            // Кожен об'єкт має власні значення полів і займає окрему область пам'яті

            // Створюємо перший ОБ'ЄКТ класу BankAccount
            BankAccount account1 = new BankAccount(); // account1 - це об'єкт/екземпляр
            // Створюємо другий ОБ'ЄКТ того ж класу
            BankAccount account2 = new BankAccount(5000); // account2 - інший об'єкт/екземпляр

            // Ці два об'єкти незалежні один від одного
            account1.Deposit(1000); // Впливає тільки на account1
            account2.Deposit(500);  // Впливає тільки на account2

            Console.WriteLine($"Баланс account1: {account1.Balance}"); // 1000
            Console.WriteLine($"Баланс account2: {account2.Balance}"); // 5500

            Console.WriteLine("\n=== ДЕМОНСТРАЦІЯ КОМПОЗИЦІЇ ===");
            // КОМПОЗИЦІЯ: Car створює власний Engine
            Car car1 = new Car("Toyota", 2020);
            Console.WriteLine(car1.ToString());

            Console.WriteLine("\n=== ДЕМОНСТРАЦІЯ АГРЕГАЦІЇ ===");
            // АГРЕГАЦІЯ: створюємо Engine окремо і передаємо в Car
            Engine customEngine = new Engine { Type = "Дизельний", Power = 200 };
            Car car2 = new Car(customEngine, "BMW", 2022);
            Console.WriteLine(car2.ToString());

            Console.WriteLine("\n=== РІЗНИЦЯ МІЖ КЛАСОМ ТА ОБ'ЄКТОМ ===");
            // КЛАС Person - це шаблон
            // person1 та person2 - це ОБ'ЄКТИ (екземпляри) класу Person
            Person person1 = new Person("Саша", 25);  // Перший об'єкт
            Person person2 = new Person("Діма", 30);  // Другий об'єкт

            // Кожен об'єкт має свої унікальні дані
            Console.WriteLine($"person1: {person1.Name}, вік: {person1.Age}");
            Console.WriteLine($"person2: {person2.Name}, вік: {person2.Age}");

            // Зміна одного об'єкта не впливає на інший
            person1.Age = 26; // Змінюємо вік тільки у person1
            Console.WriteLine($"Після зміни - person1: {person1.Age}, person2: {person2.Age}");

            Console.WriteLine("\n=== РОБОТА З PERSON ===");

            Console.WriteLine($"Ім'я: {person2.Name}");

            // Демонстрація валідації властивості
            person1.Name = ""; // Помилка валідації
            person1.Name = "s"; // Помилка валідації
            person1.Name = "Олександр"; // Успішно

            Console.WriteLine("\n=== МНОЖИННІ ОБ'ЄКТИ ОДНОГО КЛАСУ ===");
            // Можемо створити багато об'єктів одного класу
            Car[] cars = new Car[3]; // Масив для зберігання об'єктів Car
            cars[0] = new Car("Toyota", 2020);    // Перший об'єкт Car
            cars[1] = new Car("Honda", 2019);     // Другий об'єкт Car  
            cars[2] = new Car("BMW", 2023);       // Третій об'єкт Car

            Console.WriteLine("Список автомобілів:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i]}"); // Кожен об'єкт має свої дані
            }

            Console.WriteLine("\n=== РОБОТА З БАНКІВСЬКИМ РАХУНКОМ ===");
            // Використання різних конструкторів
            BankAccount account3 = new BankAccount(); // Конструктор за замовчуванням
            BankAccount account4 = new BankAccount(3000); // Перевантажений конструктор

            account4.Deposit(1000);
            account4.Withdraw(500);

            Console.WriteLine($"Баланс account3: {account3.Balance}"); // 0 (інший об'єкт!)
            Console.WriteLine($"Баланс account4: {account4.Balance}"); // 3500

            // Демонстрація життєвого циклу об'єктів
            Console.WriteLine("\n=== ЖИТТЄВИЙ ЦИКЛ ОБ'ЄКТІВ ===");
            Car tempCar = new Car("Honda", 2019); // Створюємо об'єкт
            Console.WriteLine($"Створено об'єкт: {tempCar}");
            tempCar = null; // Видаляємо посилання на об'єкт
            Console.WriteLine("Об'єкт став недоступним і буде видалений збирачем сміття");

            // ВАЖЛИВО: 
            // - КЛАС існує один раз у коді як шаблон
            // - ОБ'ЄКТИ створюються багато разів у пам'яті за цим шаблоном
            // - Кожен об'єкт незалежний і має власні значення полів
        }
    }
}
