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
        public List<int> Location;
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

        public bool CheckforShip(int x, int y, int dir, Ship item)
        {
            if (dir == 1)
            {
                for (int i = 0; i < item.Width; i++)
                {
                    int temp = x + i;

                    if (gameBoard.Tile[temp, y] != "E")
                    {
                        return true;
                    }
                }
            }
            if (dir == 0)
            {
                for (int i = 0; i < item.Width; i++)
                {
                    int temp = y + i;

                    if (gameBoard.Tile[x, temp] != "E")
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
