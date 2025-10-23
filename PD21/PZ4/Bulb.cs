using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Bulb: ISwitchable, IDamageable
    {
        public int HP = 5;
        private bool _isOn;

        public void On()
        {
            _isOn = true;
            Console.WriteLine("Bulb is ON.");
        }

        public void Off()
        {
            _isOn = false;
            Console.WriteLine("Bulb is OFF.");
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
        }
    }
}
