using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleShip.ShipType;
namespace BattleShip
{
    class Computer : User
    {
        
        Random placement = new Random();
        int dir;
        int x;
        int y;

        public override void PlaceShip()
        {
            
  
                // Console.WriteLine("what direction would you like to place your Sub");
                //return a direction that ship can be placed  
                //foreach (Ship type in Ships)
                //{

            //}s
            foreach (var item in Ships)
                {
                if (!item.Isplaced)
                {
                    Console.Clear();
                    gameBoard.UpdateGame();
                    CheckBounds(item);
                    if (CheckforShip(x, y, dir, item))
                    {
                        CheckBounds(item);
                    }
                    switch (dir)
                    {
                        case 0:
                            for (int i = 0; i < item.Width; i++)
                            {
                                int temp = y + i;
                                while (gameBoard.Tile[x, temp] == "E")
                                {
                                    gameBoard.Tile[x, temp] = GetDescription(item.OccupationType);
                                }
                            }
                            item.Isplaced = true;
                            gameBoard.UpdateGame();
                            break;
                        case 1:
                            for (int i = 0; i < item.Width; i++)
                            {
                                int temp = x + i;
                                while (gameBoard.Tile[temp, y] == "E")
                                {
                                    gameBoard.Tile[temp, y] = GetDescription(item.OccupationType);
                                }
                            }
                            item.Isplaced = true;
                            gameBoard.UpdateGame();
                            break;
                        default:
                            Console.WriteLine("No correct information entered try again!");
                            PlaceShip();
                            break;
                    }
                }
            }
       
           
        }
        public void CheckBounds(Ship ship)
        {
            dir = placement.Next(0, 1);
            //Seed x,y then check if its empty
            do
            {
                x = placement.Next(0, 19);
                System.Threading.Thread.Sleep(20);
                y = placement.Next(0, 19);
            } while (gameBoard.Tile[x,y] != "E");
// check if ship goes out of bounds if it is places to the right
            if (dir == 0 && (x + ship.Width > 19 || y + ship.Width - 1 > 19))
            {
                while (x > 19 || y + ship.Width - 1 > 19)
                {
                    do
                    {
                        gameBoard.UpdateGame();
                        Console.WriteLine("Can not place ship this is out of bounds!");
                        //0-1(right,down)
                        x = placement.Next(0, 19);
                        System.Threading.Thread.Sleep(20);
                        y = placement.Next(0, 19);
                        dir = placement.Next(0, 1);
                        if (dir == 1)
                        {
                            break;
                        }
                    } while (gameBoard.Tile[x, y] != "E");
                    break;
                }
            }
            //is ship going out of bounds if placed down
            if (dir == 1 && x + ship.Width > 19 || y + ship.Width - 1 > 19)
            {
                while (x + ship.Width > 19)
                {
                    do
                    {
                        Console.WriteLine("Can not place ship this is out of bounds!");
                        //0-1(right,down)
                        x = placement.Next(0, 19);
                        System.Threading.Thread.Sleep(20);
                        y = placement.Next(0, 19);
                        dir = placement.Next(0, 1);
                    } while (gameBoard.Tile[x, y] != "E");
                }
            }
         }
    }
}
