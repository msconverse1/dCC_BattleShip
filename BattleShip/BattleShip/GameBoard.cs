using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
   public class GameBoard
    {
     
        string[,] tile = new string[20, 20];

 

        public int boardSize = 20;

        public string[,] Tile { get => tile; set => tile = value; }

        public GameBoard()
        {
            //SetPanel(new List<Tiles>());
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        GetPanel().Add(new Tiles(i, j));
            //    }
            //}
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    tile[i, j] = "E";
                }
            }
        }

        public void PrintGameBoard()
        {
            //for (int col = 0; col < tiles.Count(); col++)
            //{
            //    if (col % boardSize == 0  )
            //    {
            //        Console.Write("\n");
            //        for (int i = 0; i < boardSize; i++)
            //        {
            //            Console.Write("--------");
            //        }
            //        Console.WriteLine("");
            //    }
            //        Console.Write(tiles.ElementAt(col).OccupationType+ " | ");
            //}
            for (int j = 0; j < tile.GetLength(1); j++)
            {
                for (int i = 0; i < tile.GetLength(0); i++)
                {
                    Console.Write(tile[j, i]);
                }
                Console.WriteLine();
            }
        }
        public void UpdateGame()
        {
            Console.Clear();
            PrintGameBoard();
        }

     



    }
}
     


