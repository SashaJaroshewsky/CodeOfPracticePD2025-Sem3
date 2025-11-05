using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    internal class Laptop : Device, ISwitchable
    {
        public string DeviceName => Name;

        public Laptop(string name) : base(name)
        {
        }

    }
}
