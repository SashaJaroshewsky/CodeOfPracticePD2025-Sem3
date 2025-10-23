using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Mage : Character
    {
        public Mage(int health, int attackPower) : base(health, attackPower)
        {
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            Console.WriteLine($"Маг отримав пошкодження {damage}, здоров'я {Health}");
        }

        protected override void Die()
        {
            Console.WriteLine("Мага сіяй");
        }
    }
}
