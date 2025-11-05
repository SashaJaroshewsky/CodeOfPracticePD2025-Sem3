using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    internal class Phone : Device, IChargeable
    {
        public Phone(string name) : base(name)
        {
        }

        public void Charge()
        {
            Console.WriteLine($"{Name}: Телефон заряджається");
        }
    }
    
}
