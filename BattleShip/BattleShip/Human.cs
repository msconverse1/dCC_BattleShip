using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Human : User
    {
        public override void PlaceShip()
        {
            
            Console.WriteLine("where would you like to plays your Sub");
            gameBoard.GetPanel()[2].OccupationType = ShipType.OccupationType.Submarine;
            gameBoard.GetPanel()[22].OccupationType = ShipType.OccupationType.Submarine;
            gameBoard.UpdateGame();
        }

    }
}
