using static BattleShip.ShipType;

namespace BattleShip
{
    public abstract class Ship
    {
       public string Name;
        public int Width;
        public int Hit;
        public OccupationType OccupationType { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hit <= Width;
            }
        }
    }
}
