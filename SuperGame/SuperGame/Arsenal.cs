using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    class WeaponArsenal
    {
        public readonly Weapon sword = new Weapon("Sword", 3,Weapons.slashing);
        public readonly Weapon spear = new Weapon("Spear", 2,Weapons.piercing);
        public readonly Weapon mace = new Weapon("Mace", 5, Weapons.bludgeoning);
        public readonly Weapon axe = new Weapon("Axe", 5, Weapons.slashing);
    }
    class ArmorArsenal
    {
        public readonly Armor leater = new Armor("Leater", 0.2f, Armors.light);
        public readonly Armor chainmail = new Armor("Chainmail", 0.4f, Armors.medium);
        public readonly Armor plate = new Armor("Plate", 0.6f, Armors.heavy);


    }
}
