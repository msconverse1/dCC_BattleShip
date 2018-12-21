using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameLogic
    {
        User Player1;
        User Player2;

        public GameLogic()
        {
            Player1 = new Human();
            Player2 = new Computer();
        }
        public void PlayGame()
        {
            Player2.gameBoard.PrintGameBoard(Player1.gameBoard.GetPanel(), Player1.gameBoard.boardSize);
            Console.ReadLine();
            Console.Clear();
            Player2.PlaceShip();
           // Player1.gameBoard.UpdateGame();
            Console.ReadLine();
        }
    }
}
