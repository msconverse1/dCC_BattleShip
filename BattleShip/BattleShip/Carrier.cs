using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Carrier";
            Width = 5;
            OccupationType = ShipType.OccupationType.Carrier;
        }
    }
}
