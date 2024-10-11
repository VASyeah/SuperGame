using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    interface IUnit
    {
        #region properties
        float Health { get; set; }
        float Damage { get; }
        IArmor Armor { get; }
        IWeapon Weapon { get; }
        #endregion
        #region methods
        bool Attack(IUnit enemy);
        bool Block();
        void Heal(float vlaue);
        #endregion
    }
}
