using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Lever
    {
        public ISwitchable ConnectedDevice { get; set; }

        private bool _leverState;

        public Lever(ISwitchable device)
        {
            ConnectedDevice = device;
            _leverState = false;
        }


        public void Pull()
        {
            if (!_leverState)
            {
               On();
            }
            else
            {
                Off();
            }
        }

        public void On()
        {
            Console.WriteLine("Lever = true");
            _leverState = true;
            ConnectedDevice.On();
        }

        public void Off()
        {
            Console.WriteLine("Lever = false");
            _leverState = false;
            ConnectedDevice.Off();
        }
    }
}
