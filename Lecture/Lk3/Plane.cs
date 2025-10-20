using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lk3
{
    internal class Plane: Transport
    {
        public Plane(string model) : base(model)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Літак летить в небі");
        }
    }
    
}
