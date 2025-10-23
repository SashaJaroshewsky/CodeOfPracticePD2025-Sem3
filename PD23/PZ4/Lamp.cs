using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Lamp: ISwitcheable, IDamageable
    {
        private int _hp;

        public Lamp()
        {
            _hp = 5;
        }
        public void On()
        {
            Console.WriteLine("Lamp is turned on");
        }

        public void Off()
        {
            Console.WriteLine("Lamp is turned off");
        }

        public void TakeDamage(int damage)
        {
            _hp -= damage;
            if (_hp < 0)
            {
                _hp = 0;
            }
            if(_hp <= 0)
            {
                Console.WriteLine("Lamp is broken");
            }
            else
            {
                Console.WriteLine($"Lamp took {damage} damage, remaining health: {_hp}");
            }
        }
    }
}
