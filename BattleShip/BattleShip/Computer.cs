using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Computer : User
    {
        public override void PlaceShip()
        {
            Random placement = new Random();
            int max = gameBoard.GetPanel().Count - 1;
            int dir =0;
            int maxCol = gameBoard.boardSize-1;
            int maxRow = gameBoard.boardSize - 1;
            int number = placement.Next(0, max);
            int placeleft = number - 1;           
            Console.WriteLine("what direction would you like to place your Sub");
            // string dir= Console.ReadLine();
          //return a direction that ship can be placed
            dir = gameBoard.CheckBoundrys( number,  dir,  placement, maxCol,maxRow);
            dir = gameBoard.CheckIfVaildDirection(dir, number, maxCol, maxRow);
            switch (dir)
            {
                //down
                case 1:
                    gameBoard.GetPanel()[number].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number + gameBoard.boardSize].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number + gameBoard.boardSize+ gameBoard.boardSize].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.UpdateGame();
                    break;
                    //left
                case 2:
                    gameBoard.GetPanel()[number].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number -1].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number - 2].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.UpdateGame();
                    break;
                    //right
                case 3:
                    gameBoard.GetPanel()[number].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number + 1].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number +2].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.UpdateGame();
                    break;
                    //up
                case 4:
                    gameBoard.GetPanel()[number].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number - gameBoard.boardSize].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.GetPanel()[number - gameBoard.boardSize- gameBoard.boardSize].OccupationType = ShipType.OccupationType.Submarine;
                    gameBoard.UpdateGame();
                    break;
            }
        }
    }
}
