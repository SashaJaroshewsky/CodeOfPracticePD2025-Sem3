using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Robot : Character, ISwitcheable
    {
        public Robot(int health, int damage ) : base(health, damage)
        {
        }

        public void Off()
        {
            Console.WriteLine("Робот виключився");
        }

        public void On()
        {
            Console.WriteLine("Робот включився");        }

        public override void TakeDamage(int damage)
        {
            int reducedDamage = damage / 2;
            base.TakeDamage(reducedDamage);
           
        }

        protected override void Die()
        {
            Console.WriteLine("Робот розсипався на запчастини");
        }
    }
}
