using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal abstract class Character: IDamageable
    {
        private int _health;
        private int _damage;
        public Character(int health, int damage)
        {
            _health = health;
            _damage = damage;
        }

        public virtual void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
            Console.WriteLine($"Character took {damage} damage, remaining health: {_health}");
            if (_health <= 0)
            {
                Die();
            }
        }

        public void Attack(IDamageable target)
        {
            target.TakeDamage(_damage);
        }



        protected abstract void Die();
        
    }
}
