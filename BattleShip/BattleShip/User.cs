using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class User
    {
        string name;
        int score;
        bool allShipsDestroyed;
       public GameBoard gameBoard;
        public List<Ship> Ships;
        public User()
        {
            gameBoard = new GameBoard();
            CreateShips();
        }
        void SetName(string name)
        {
            this.name = name;
        }
        void CreateShips()
        {
            Ships = new List<Ship>()
            {
            new Destroyer(),
            new Submarine(),
            new Cruiser(),
            new Battleship(),
            new Carrier()
            };
        }
       public  virtual void PlaceShip()
        {

        }




    }
}
