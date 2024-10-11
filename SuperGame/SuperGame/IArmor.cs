using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    interface IArmor
    {
        string Name { get; }
        float Defense { get; }
        Armors Type { get; }
    }
}
