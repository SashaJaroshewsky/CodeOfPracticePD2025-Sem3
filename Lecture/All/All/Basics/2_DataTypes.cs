using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Basics
{
    /// <summary>
    /// 2. DataTypes — Типи даних
    /// 
    /// ТЕОРІЯ:
    /// C# — мова зі строгою типізацією. Основні типи даних:
    /// 
    /// ЦІЛОЧИСЕЛЬНІ:
    /// - byte: 0 до 255 (1 байт)
    /// - short: -32,768 до 32,767 (2 байти)
    /// - int: -2,147,483,648 до 2,147,483,647 (4 байти)
    /// - long: дуже великі числа (8 байтів)
    /// 
    /// ДРОБОВІ:
    /// - float: ~7 цифр точності (4 байти) — додається суфікс f
    /// - double: ~15-16 цифр точності (8 байтів)
    /// - decimal: ~28-29 цифр точності (16 байтів) — для грошей, додається m
    /// 
    /// ІНШІ:
    /// - bool: true або false
    /// - char: один символ ('A')
    /// - string: текст ("Привіт")
    /// </summary>
    public class DataTypes
    {
        public void DemonstrateTypes()
        {
            // Цілочисельні типи
            byte age = 25;              // Вік людини
            short year = 2024;          // Рік
            int population = 1000000;   // Населення міста
            long worldPop = 8000000000L;// Населення світу

            // Дробові типи
            float height = 1.75f;       // Зріст в метрах (f — обов'язковий!)
            double pi = 3.14159265359;  // Число π
            decimal price = 199.99m;    // Ціна товару (m — обов'язковий!)

            // Інші типи
            bool isStudent = true;      // Логічний тип
            char grade = 'A';           // Один символ
            string name = "Іван";       // Рядок тексту

            // Виведення
            Console.WriteLine($"Вік: {age}, Ім'я: {name}, Студент: {isStudent}");
        }
    }
}
