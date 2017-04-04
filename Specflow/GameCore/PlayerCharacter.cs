using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class PlayerCharacter
    {
        public void Hit(int damage)
        {
            Health -= damage;
        }
        public int Health { get; private set; } = 100;

        public bool IsDead {
            get { return Health <= 0; }
            private set { }
        } 
    }
}
