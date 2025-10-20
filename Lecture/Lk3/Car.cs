using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lk3
{
    internal class Car : Transport
    {
        public Car(string model) : base(model)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Автомобіль їде по дрозі");
        }
    }
}
