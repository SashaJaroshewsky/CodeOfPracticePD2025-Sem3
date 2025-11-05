using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    internal abstract class Device
    {
        private string name;
        public string Name
        {
            get { return name; }

            private set
            {
                if (Name.Length >= 20 && Name.Length <= 3)
                    Console.WriteLine("dlogsheoigj");
                name = value;
            }
        }

        public Device(string name)
        {
            Name = name;
        }
    }
}
