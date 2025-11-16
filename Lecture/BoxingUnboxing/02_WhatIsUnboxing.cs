using System;

namespace BoxingUnboxingLessons
{
    /// <summary>
    /// Що таке Unboxing (Розпакування)?
    /// 
    /// Unboxing - це процес перетворення типу посилання (object) 
    /// назад в тип значення (value type).
    /// 
    /// Під час unboxing відбувається:
    /// 1. Перевірка типу об'єкта
    /// 2. Копіювання значення з heap назад в stack
    /// 3. Якщо тип не співпадає - виникає помилка InvalidCastException
    /// </summary>
    public class WhatIsUnboxing
    {
        public static void Demo()
        {
            Console.WriteLine("=== Урок 2: Що таке Unboxing? ===\n");

            // Спочатку робимо boxing
            int originalNumber = 42;
            object boxedNumber = originalNumber;
            Console.WriteLine($"Упаковане значення: {boxedNumber}");

            // Unboxing - витягуємо значення назад
            // ВАЖЛИВО: потрібно вказати правильний тип!
            int unboxedNumber = (int)boxedNumber;
            Console.WriteLine($"Розпаковане значення: {unboxedNumber}");

            // Приклад помилки: спроба unboxing в неправильний тип
            try
            {
                // Це викличе помилку, бо в object зберігається int, а не long
                long wrongType = (long)boxedNumber;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"\n❌ Помилка: {ex.Message}");
                Console.WriteLine("Не можна розпакувати int як long!");
            }

            // Правильний спосіб конвертації через тип
            int tempInt = (int)boxedNumber;
            long correctConversion = tempInt;
            Console.WriteLine($"\n✓ Правильна конвертація: {correctConversion}");
        }
    }
}