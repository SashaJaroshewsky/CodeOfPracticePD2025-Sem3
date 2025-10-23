using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Robot : Character, ISwitchable
    {

        public Robot(int health, int damage) : base(health, damage)
        {
        }

        public void Off()
        {
            Console.WriteLine("Robot is off");
        }

        public void On()
        {
            Console.WriteLine("Robot is on");
        }

        public override void TakeDamage(int damage)
        {
            // Robots take half damage
            int reducedDamage = damage / 2;
            base.TakeDamage(reducedDamage);
            Console.WriteLine($"Robot: Damage={reducedDamage}, HP: {Health}");
        }

        protected override void Die()
        {
            Console.WriteLine("Robot is dead");
        }
    }
}
