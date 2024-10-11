using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    class Armor : IArmor
    {
        private string _name;
        private Armors _type;
        private float _defense;


        public string Name => _name;

        public Armors Type => _type;


        public float Defense => _defense;
        public Armor(string name, float defense, Armors type)
        {
            _name = name;
            _type = type;
            _defense = defense;

        }
    }
}
