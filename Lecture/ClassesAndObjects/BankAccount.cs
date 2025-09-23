using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    // КЛАС - це шаблон (креслення) для створення об'єктів
    // Містить поля, властивості, конструктори та методи
    // Клас сам по собі не займає пам'ять - це лише опис того, як будуть виглядати об'єкти
    public class BankAccount
    {
        // ПОЛЕ (field) - приватна змінна класу
        // ІНКАПСУЛЯЦІЯ: використовуємо private для приховування внутрішньої реалізації
        private decimal _balance;

        // КОНСТРУКТОР ЗА ЗАМОВЧУВАННЯМ (default constructor)
        // Викликається при створенні об'єкта без параметрів: new BankAccount()
        public BankAccount()
        {
            _balance = 0;
        }

        // ПЕРЕВАНТАЖЕНИЙ КОНСТРУКТОР (overloaded constructor)
        // Дозволяє створити об'єкт з початковим балансом: new BankAccount(1000)
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        // PUBLIC метод - доступний ззовні класу
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
            else
            {
                Console.WriteLine("Сума депозиту має бути позитивною.");
            }
        }

        // PUBLIC метод для зняття коштів
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Неправильна сума для зняття.");
            }
        }

        // ВЛАСТИВІСТЬ (property) тільки для читання
        // Дозволяє безпечно отримати баланс ззовні класу
        public decimal Balance
        {
            get { return _balance; }
        }
    }
}
