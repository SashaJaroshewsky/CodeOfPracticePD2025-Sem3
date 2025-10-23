using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Bulb: ISwitchable, IDamageable
    {
        public int HP { get; private set; } = 5;
        public bool IsOn { get; private set; }
        public void On()
        {
            IsOn = true;
            Console.WriteLine("Bulb is ON.");
        }
        public void Off()
        {
            IsOn = false;
            Console.WriteLine("Bulb is OFF.");
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
        }
    }
}
