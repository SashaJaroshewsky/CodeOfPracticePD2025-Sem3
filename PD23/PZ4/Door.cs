using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Door : ISwitcheable, IDamageable
    {
        private int _hp;
        public Door()
        {
            _hp = 10;
        }
        public void TakeDamage(int damage)
        {
            _hp -= damage;
            if (_hp < 0)
            {
                _hp = 0;
            }
            if (_hp <= 0)
            {
                Console.WriteLine("Door is broken");
            }
            else
            {
                Console.WriteLine($"Door took {damage} damage, remaining health: {_hp}");
            }
        }


        public void On()
        {
            Console.WriteLine("Door is opened");
        }

        public void Off()
        {
            Console.WriteLine("Door is closed");
        }
    }
}
