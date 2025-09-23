using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Car
    {
        // PRIVATE поле для Engine
        private Engine _engine;

        // АВТОВЛАСТИВОСТІ (auto-properties)
        // Компілятор автоматично створює приховане поле та get/set методи
        public string Model { get; set; }
        public int Year { get; set; }

        // КОМПОЗИЦІЯ: Car створює власний Engine і повністю контролює його життєвий цикл
        // Коли Car знищується, Engine теж знищується
        public Car(string model, int year)
        {
            _engine = new Engine(); // Car створює Engine - це КОМПОЗИЦІЯ
            Model = model;
            Year = year;
        }

        // АГРЕГАЦІЯ: Car отримує готовий Engine ззовні
        // Engine може існувати незалежно від Car
        public Car(Engine engine, string model, int year)
        {
            _engine = engine; // Car використовує існуючий Engine - це АГРЕГАЦІЯ
            Model = model;
            Year = year;
        }

        // Перевизначення методу ToString для зручного виводу
        public override string ToString()
        {
            return $"{Year} {Model} з двигуном {_engine.Type} ({_engine.Power} к.с.)";
        }
    }
}
