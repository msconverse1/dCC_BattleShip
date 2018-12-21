using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleShip.ShipType;

namespace BattleShip
{
   public class Tiles
    {
        public OccupationType OccupationType { get; set; }
        public Coordinates Coordinates { get; set; }

        public Tiles(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            OccupationType = OccupationType.Empty;
        }

        public bool IsOccupied
        {
            get
            {
                return OccupationType == ShipType.OccupationType.Battleship
                    || OccupationType == ShipType.OccupationType.Destroyer
                    || OccupationType == ShipType.OccupationType.Cruiser
                    || OccupationType == ShipType.OccupationType.Submarine
                    || OccupationType == ShipType.OccupationType.Carrier;
            }
        }

        public bool MakeRandomShotAvailable
        {
            get
            {
                return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
                    || (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
            }
        }
    }
}
