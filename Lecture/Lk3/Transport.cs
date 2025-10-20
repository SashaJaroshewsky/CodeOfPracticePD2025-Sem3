using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lk3
{
    internal abstract class Transport
    {
        public string Model { get; private set; }

        public Transport(string model)
        {
            Model = model;
        }
        public abstract void Move();

        public void StartEngine()
        {
            Console.WriteLine("Двигун заведено");
        }

    }
}
