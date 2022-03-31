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

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

    }
}
