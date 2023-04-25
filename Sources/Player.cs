using System;

namespace Napilnik.Sources
{
    class Player : IDamageable
    {
        private int _health;

        public bool IsDead => _health <= 0;

        public Player(int health)
        {
            if (health < 0)
                throw new ArgumentOutOfRangeException(nameof(health));

            _health = health;
        }

        public event Action Died;

        public void ApplyDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (IsDead)
                return;

            _health -= damage;

            if (IsDead)
                Died?.Invoke();
        }
    }
}