using System;

namespace Napilnik.Sources
{
    class Weapon
    {
        private readonly int _damage;

        public Weapon(int damage, int bullets)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            _damage = damage;
            Bullets = bullets;
        }
        
        public int Bullets { get; private set; }
        public bool CanFire => Bullets > 0;
        
        public void Fire(IDamageable damageable)
        {
            if(CanFire == false)
                return;
            
            damageable.ApplyDamage(_damage);
            Bullets -= 1;
        }
    }
}