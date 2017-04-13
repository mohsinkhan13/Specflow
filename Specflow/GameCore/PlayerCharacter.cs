using System;
using System.Collections.Generic;

namespace GameCore
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            Attributes = new PlayerAttributes();
            Weapons = new List<Weapon>();
        }
        public PlayerAttributes Attributes { get; set; }
        public int Health { get; set; } = 100;

        public DateTime LastSlept { get; set; } = DateTime.Today;
        public bool IsDead {
            get { return Health <= 0; }
            private set { }
        }

        public List<Weapon> Weapons { get; set; }

        public void Hit(int damage)
        {
            if (damage > 0 && LastSlept < DateTime.Today)
            {
                Health = 0;
                return;
            }

            var totalDamage = damage - Attributes.Resistance;
            if (Attributes.Race == "Elf")
                totalDamage = totalDamage - 20;

            Health -= totalDamage < 0 ? 0 : totalDamage;
        }

    }

}
