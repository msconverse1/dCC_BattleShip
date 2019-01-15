using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            Hit,Miss,Sunk
        }
        public static string GetDescription(OccupationType ShipType)
        {
            System.Reflection.FieldInfo oFieldInfo = ShipType.GetType().GetField(ShipType.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])oFieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return ShipType.ToString();
            }
        }

    }
}
