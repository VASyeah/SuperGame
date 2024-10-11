using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    interface IWeapon
    {
        string Name { get; }
        float Damage { get; }
        Weapons Type { get; }

    }
}
