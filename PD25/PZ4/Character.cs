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

        public int Health => _health;
        public int Damage => _damage;

        public Character(int health, int damage)
        {
            _health = health;
            _damage = damage;
        }

        public void Attack(IDamageable target)
        {
            target.TakeDamage(Damage);
        }
        public virtual void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0) _health = 0;
            if (_health <= 0)
            {
                Die();
            }
        }

        protected abstract void Die();

    }
}
