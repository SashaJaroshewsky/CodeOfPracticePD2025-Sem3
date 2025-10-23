using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Lever
    {
        public bool IsOn { get; private set; }
        public ISwitchable ConnectedDevice { get; set; }

        public Lever(ISwitchable switchable)
        {
            IsOn = false;
            ConnectedDevice = switchable;
        }

       
        public void Pull()
        {
            if (IsOn)
            {
                Off();
                
            }
            else
            {
                On();
                
            }
        }

        private void On()
        {

            IsOn = true;
            ConnectedDevice.On();
            Console.WriteLine("Lever is ON.");
        }

        private void Off()
        {
            IsOn = false;
            ConnectedDevice.Off();
            Console.WriteLine("Lever is OFF.");
        }

    }
}
