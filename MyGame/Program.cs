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
            for (int i = 0; i < nEnemies; i++)
            {
                enemy = new Enemy(Console.ReadLine());
                army[i] = enemy;
            }
            for (int i = 0; i < army.Length; i++)
            {
                Console.WriteLine(army[i].GetName());
            }
            
        }
    }
}
