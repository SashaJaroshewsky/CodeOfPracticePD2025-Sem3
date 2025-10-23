using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Robot : Character, ISwitchable
    {
        public bool IsOn { get; private set; }
        public Robot(int health, int attackPower) : base(health, attackPower)
        {
        }

        public void Off()
        {
            IsOn = false;
            Console.WriteLine("Робот вимкнений");
        }

        public void On()
        {
            IsOn = true;
            Console.WriteLine("Робот увімкнений");
        }

        public override void TakeDamage(int damage)
        {
            int reducedDamage = damage / 2;
            base.TakeDamage(reducedDamage);
            Console.WriteLine($"Робот отримав пошкодження {reducedDamage}, здоров'я {Health}"); 
        }

        protected override void Die()
        {
            Console.WriteLine("Робот розсипався на деталі");
        }
    }
}
