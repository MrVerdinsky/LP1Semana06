using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int nPowerUps;

        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;

        }
        static Enemy()
        {
            nPowerUps = 0; 
        }

        public static float GetNPowerUps() => nPowerUps;
        public float GetHealth() => health;

        public float GetShield() => health;

        public string GetName() => name;

        public string SetName(string name) => name.Trim();

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToINflict = -shield;
                shield = 0;
                health -= damageStillToINflict;
                if (health < 0) health = 0;
            }
        }

        public void PickUpPowerUp(PowerUp pwrUp, float value)
        {
            nPowerUps++;
            if (pwrUp == PowerUp.Health)
            {
                health += value;
                if (health > 100) health = 100;
            }

            else if (pwrUp == PowerUp.PowerUp)
            {
                shield += value;
                if (shield > 100) shield = 100;
            }
        }

    }
}
