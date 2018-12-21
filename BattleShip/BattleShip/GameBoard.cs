using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
   public class GameBoard
    {
        private List<Tiles> panel;

        public List<Tiles> GetPanel()
        {
            return panel;
        }

        public void SetPanel(List<Tiles> value)
        {
            
            panel = value;
        }

        public int boardSize = 20;
        public GameBoard()
        {
            SetPanel(new List<Tiles>());
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    GetPanel().Add(new Tiles(i, j));
                }
            }
        }

        public void PrintGameBoard(List<Tiles> tiles,int boardSize)
        {
            for (int col = 0; col < tiles.Count(); col++)
            {
                if (col % boardSize == 0  )
                {
                    Console.Write("\n");
                    for (int i = 0; i < boardSize; i++)
                    {
                        Console.Write("--------");
                    }
                    Console.WriteLine("");
                }
                    Console.Write(tiles.ElementAt(col).OccupationType+ " | ");
            }
        }
        public void UpdateGame()
        {

            PrintGameBoard(GetPanel(), boardSize);
        }

        public int CheckBoundrys(int number,int dir,Random placement,int maxCol,int maxRow)
        {
            //bottomleft
            if (GetPanel()[number].Coordinates.Column == 0 && GetPanel()[number].Coordinates.Row == maxRow)
            {
                do
                {
                    dir = placement.Next(1, 4);
                } while (dir == 1 || dir == 2);
                return dir;
            }
            //bottomright
            else if (GetPanel()[number].Coordinates.Column == maxCol && GetPanel()[number].Coordinates.Row == maxRow)
            {
                do
                {
                    dir = placement.Next(1, 4);
                } while (dir == 1 || dir == 3);
                return dir;
            }
            //topleft
            else if (GetPanel()[number].Coordinates.Column == 0 && GetPanel()[number].Coordinates.Row == 0)
            {
                do
                {
                     dir = placement.Next(1, 4);
                } while (dir == 2 || dir == 4);
                return dir;
            }
            //topright
            else if (GetPanel()[number].Coordinates.Column == maxCol && GetPanel()[number].Coordinates.Row == 0)
            {
                do
                {
                    dir = placement.Next(1, 4);
                } while (dir == 3 || dir == 4);
                return dir;
            }
            //top
            else if (GetPanel()[number].Coordinates.Row == 0)
            {
                do
                {
                    dir = placement.Next(1, 4);
                } while (dir == 4);
                return dir;
            }
            //bottom
            else if (GetPanel()[number].Coordinates.Row == maxRow)
            {
                do
                {
                    dir = placement.Next(1, 4);
                } while (dir == 1);
                return dir;
            }
            //left
            else if (GetPanel()[number].Coordinates.Column == 0)
            {
                do
                {
                    dir = placement.Next(1, 4);
                } while (dir == 2);
                return dir;
            }
            //right
            else if (GetPanel()[number].Coordinates.Column == maxCol)
            {
                do
                {
                    dir = placement.Next(1, 4);
                } while (dir == 3);
                return dir;
            }
            else
            {
                return dir = placement.Next(1, 4);
            }
        }

        public int CheckIfVaildDirection(int dir,int number,int maxCol,int maxRow)
        {
            if (dir == 1 && (GetPanel()[number + boardSize].Coordinates.Row > maxRow || GetPanel()[number + boardSize + boardSize].Coordinates.Row > maxRow))
            {
                return dir = CheckIfVaildDirection(dir, number, maxCol, maxRow);
            }
            else if (dir == 2 && (GetPanel()[number - 1].Coordinates.Row < 0 || GetPanel()[number - 2].Coordinates.Row < 0))
            {
                return dir = CheckIfVaildDirection(dir, number, maxCol, maxRow);
            }
            else if (dir == 3 && (GetPanel()[number + 1].Coordinates.Row < maxCol || GetPanel()[number + 2].Coordinates.Row < maxCol))
            {
                return dir = CheckIfVaildDirection(dir, number, maxCol, maxRow);
            }
            else if (dir == 4 && (GetPanel()[number - boardSize].Coordinates.Column < 0 || GetPanel()[number - boardSize - boardSize].Coordinates.Column < 0))
            {
                return dir = CheckIfVaildDirection(dir, number, maxCol, maxRow);
            }
            else
                return dir;
        }


    }
}
     


