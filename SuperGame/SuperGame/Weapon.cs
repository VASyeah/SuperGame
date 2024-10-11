using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    class Weapon : IWeapon
    {
        private string _name;
        private float _baseDamage;
        private Weapons _type;

        public float Damage => _baseDamage;
        public Weapons Type => _type;
        public string Name => _name;


        public Weapon(string name,float damage, Weapons type)
        {
            _name = name;
            _baseDamage = damage;
            _type = type;
        }
        public float AtackDamage(IArmor armor)
        {
            return armor.Type == Armors.light ? Damage * 1.5f : Damage;
        }
    }
}
