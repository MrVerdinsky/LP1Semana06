using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int nEnemies = Convert.ToInt32(Console.ReadLine());
            Enemy[] army = new Enemy[nEnemies];
            Enemy enemy;
            Random random = new Random();
            for (int i = 0; i < nEnemies; i++)
            {
                int rng = random.Next(0, 3);
                int rng2 = random.Next(0, 2);
                enemy = new Enemy(Console.ReadLine());
                if (rng2 == 0)
                {
                    enemy.TakeDamage(random.Next(0, 101));
                    army[i] = enemy;
                }
                if (rng == 0)
                {
                    enemy.PickUpPowerUp(PowerUp.Health, random.Next(0, 101));
                    army[i] = enemy;
                }
                else if(rng == 1)
                {
                    enemy.PickUpPowerUp(PowerUp.PowerUp, random.Next(0, 101));
                    army[i] = enemy;
                }
                else
                {
                    army[i] = enemy;
                }
            }
            for (int i = 0; i < army.Length; i++)
            {
                Console.WriteLine($"Soldier's Name: {army[i].GetName()}");
                Console.WriteLine($"Soldier's HP: {army[i].GetHealth()}");
                Console.WriteLine($"Soldier's Shield: {army[i].GetShield()}");
                Console.WriteLine();
            }
            Console.WriteLine($"Number of Power Ups Picked Up: {Enemy.GetNPowerUps()}");
            Console.WriteLine("Thank you for using this program");
            
        }
    }
}
