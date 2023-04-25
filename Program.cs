using System;
using Napilnik.Sources;

namespace Napilnik
{
    internal class Program
    {
        private static bool _isGameOver;

        public static void Main(string[] args)
        {
            Player player = new Player(100);
            player.Died += OnPlayerDied;
            
            Bot bot = new Bot(new Weapon(10, 5));
            bot.BulletsEnded += OnBulletsEnded;
            
            while (_isGameOver == false)
            {
                bot.OnSeePlayer(player);
            }
        }

        private static void OnBulletsEnded() => _isGameOver = true;

        private static void OnPlayerDied() => _isGameOver = true;
    }
}