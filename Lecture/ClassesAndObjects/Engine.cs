using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    // Простий клас Engine для демонстрації композиції/агрегації
    public class Engine
    {
        public string Type { get; set; } = "Бензиновий";
        public int Power { get; set; } = 150;
    }
}
