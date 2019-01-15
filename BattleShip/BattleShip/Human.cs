using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleShip.ShipType;

namespace BattleShip
{
    class Human : User
    {
        int x;
        int y;
        int dir;
        public override void PlaceShip()
        {
            foreach (var item in Ships)
            {
                if (!item.Isplaced)
                {
                    CheckBounds(item);
                    if (CheckforShip(x, y,dir,item))
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
        public void CheckBounds(Ship item)
        {
            //is ship on current input
            do
            {
                gameBoard.UpdateGame();
                Console.WriteLine("Where would you like to place your {0} in X,Y format:(0-19)", item.Name);
                int.TryParse(Console.ReadLine(), out x);
                int.TryParse(Console.ReadLine(), out y);
                while (x > 19 || y > 19)
                {
                    gameBoard.UpdateGame();
                    Console.WriteLine("Can not place ship this is out of bounds!");
                    Console.WriteLine("Where would you like to place your {0} in X,Y format:(0-19)", item.Name);
                    int.TryParse(Console.ReadLine(), out x);
                    int.TryParse(Console.ReadLine(), out y);
                }
            } while (gameBoard.Tile[x, y] != "E");

            //Select Direction to place current ship
            gameBoard.UpdateGame();
            Console.WriteLine("What Direction dou you want to place your {0}(Right:0 or Down:1)", item.Name);
            //0-1(right,down)
            int.TryParse(Console.ReadLine(), out dir);
            //is current ship going out of bounds to the right
            if (dir == 0 && (x + item.Width > 19 || y + item.Width - 1 > 19))
            {
                while (x > 19 || y + item.Width-1 > 19)
                {
                    do
                    {
                        gameBoard.UpdateGame();
                        Console.WriteLine("Can not place ship this is out of bounds!");
                        //0-1(right,down)
                        Console.WriteLine("Where would you like to place your {0} in X,Y format:(0-19)", item.Name);
                        int.TryParse(Console.ReadLine(), out x);
                        int.TryParse(Console.ReadLine(), out y);
                        Console.WriteLine("What Direction dou you want to place your {0}(Right:0 or Down:1)", item.Name);
                        int.TryParse(Console.ReadLine(), out dir);
                        if (dir == 1)
                        {
                            break;
                        }
                    } while (gameBoard.Tile[x, y] != "E");
                    break;
                }
            }
            //is ship going out of bounds if placed down
             if (dir == 1 && x + item.Width > 19 || y + item.Width-1 > 19)
            {
                while (x + item.Width > 19)
                {
                    do
                    {
                        Console.WriteLine("Can not place ship this is out of bounds!");
                        //0-1(right,down)
                        Console.WriteLine("Where would you like to place your {0} in X,Y format:(0-19)", item.Name);
                        int.TryParse(Console.ReadLine(), out x);
                        int.TryParse(Console.ReadLine(), out y);
                        Console.WriteLine("What Direction dou you want to place your {0}(Right:0 or Down:1)", item.Name);
                        int.TryParse(Console.ReadLine(), out dir);
                    } while (gameBoard.Tile[x, y] != "E");
                }
            }
        }

       
    }
}
