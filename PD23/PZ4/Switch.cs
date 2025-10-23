using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Switch
    {
        public bool IsOn { get; private set; }

        private ISwitcheable _switcheableObject; 
      

        public Switch(ISwitcheable switcheableObject)
        {
            _switcheableObject = switcheableObject;
            IsOn = false;
        }
        public void OnSwitch()
        {
            if (!IsOn)
            {
                On();
            }
            else
            {
                Off();
            }
        }
        private void On()
        {
            IsOn = true;
            _switcheableObject.On();
        }

        private void Off()
        {
            IsOn = false;
            _switcheableObject.Off();
        }

    }
}
