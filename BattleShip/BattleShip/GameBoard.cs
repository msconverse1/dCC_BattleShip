using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
   public class GameBoard
    {
        public List<Tiles> Panel { get; set; }
        int boardSize = 20;
        public GameBoard()
        {
            Panel = new List<Tiles>();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Panel.Add(new Tiles(i, j));
                }
            }
        }
        public void PlayGame()
        {
            PrintGameBoard(Panel,boardSize);
            Console.ReadLine();
            Console.Clear();
            UpdateGame();
            
            Console.ReadLine();
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
                    Console.Write(tiles[col].OccupationType+ " | ");
            }
        }
        public void UpdateGame()
        {
            Panel[2].OccupationType = ShipType.OccupationType.Submarine;
            PrintGameBoard(Panel, boardSize);
        }
    }
}
     


