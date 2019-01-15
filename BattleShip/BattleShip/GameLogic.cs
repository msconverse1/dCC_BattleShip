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
            Player2.gameBoard.PrintGameBoard();
            Console.WriteLine("\nPress Any Key to Continue");
            Console.ReadLine();
            Console.Clear();
            Player2.PlaceShip();
            Console.Clear();
           Player2.gameBoard.UpdateGame();
            Console.ReadLine();
        }
    }
}
