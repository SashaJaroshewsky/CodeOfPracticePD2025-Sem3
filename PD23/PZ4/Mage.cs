using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Mage: Character
    {
        public Mage(int health, int damage) : base(health, damage)
        {
        }
        public override void TakeDamage(int damage)
        {
            int reducedDamage = damage * 2;
            
            base.TakeDamage(reducedDamage);
            
        }
        protected override void Die()
        {
            Console.WriteLine("Mage has fallen in battle");
        }
    }

}
