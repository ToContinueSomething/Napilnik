using System;

namespace Napilnik.Sources
{
    class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            if (weapon == null)
                throw new ArgumentNullException(nameof(weapon));

            _weapon = weapon;
        }

        public event Action BulletsEnded;
        
        public void OnSeePlayer(Player player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if(_weapon.CanFire == false)
                BulletsEnded?.Invoke();
            
            _weapon.Fire(player);
        }
    }
}