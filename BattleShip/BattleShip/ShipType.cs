using System.ComponentModel;

namespace BattleShip
{
    public class ShipType
    {
        public enum OccupationType
        {
            [Description("O")]
            Empty,

            [Description("B")]
            Battleship,

            [Description("C")]
            Cruiser,

            [Description("D")]
            Destroyer,

            [Description("S")]
            Submarine,

            [Description("A")]
            Carrier,

            [Description("X")]
            Hit,

            [Description("M")]
            Miss
        }
        public enum HitResult
        {
            Hit,Miss
        }
    }
}
