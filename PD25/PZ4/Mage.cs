using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Mage : Character
    {
        public Mage(int health, int damage) : base(health, damage)
        {
        }
        public override void TakeDamage(int damage)
        {
            // Mages take full damage
            base.TakeDamage(damage);
            Console.WriteLine($"Mage: Damage={damage}, HP: {Health}");
        }


        protected override void Die()
        {
            Console.WriteLine("Mage is dead");
        }
    }
}
