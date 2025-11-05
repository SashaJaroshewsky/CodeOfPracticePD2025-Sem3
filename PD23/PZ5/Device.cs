using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    internal abstract class Device
    {
        
        public string Name
        {
            get ;
            private set;
            
        }

        public Device(string name)
        {
            Name = name;
        }
    }
}
