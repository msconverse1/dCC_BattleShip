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
        //int prevX;
        
        public override void PlaceShip()
        {

            foreach (var item in Ships)
            {
                if (!item.Isplaced)
                {
                    Console.Clear();
                    gameBoard.UpdateGame();
                    Console.WriteLine("Where would you like to place your {0} in X,Y format:(0-19)", item.Name);
                    int.TryParse(Console.ReadLine(), out int x);
                    int.TryParse(Console.ReadLine(), out int y);
                    if (x >= 20 || y >= 20)
                    {
                        Console.WriteLine("Can not place ship here");
                        PlaceShip();
                    }
                    else if (gameBoard.Tile[x, y] != "E")
                    {
                        Console.WriteLine("Can not place ship here one is already here!");
                        PlaceShip();
                    }
                    Console.WriteLine("What Direction dou you want to place your {0}(Right:0 or Down:1)", item.Name);
                    //0-1(right,down)
                    int.TryParse(Console.ReadLine(), out int dir);
                    //return a direction that ship can be placed
                    switch (dir)
                    {
                        case 0:
                            if (x + item.Width > 20 || y + item.Width > 20)
                            {
                                Console.WriteLine("Pick a new direction ship will not fit");
                            }
                            for (int i = 0; i < item.Width; i++)
                            {
                                
                                gameBoard.Tile[x, y] = GetDescription(item.OccupationType);
                                y += 1;
                            }
                            item.Isplaced = true;
                            gameBoard.UpdateGame();
                            break;
                        case 1:
                            if (x + item.Width > 20 || y + item.Width > 20)
                            {
                                Console.WriteLine("Pick a new direction ship will not fit");
                            }
                            for (int i = 0; i < item.Width; i++)
                            {
                                gameBoard.Tile[x, y] = GetDescription(item.OccupationType);
                                x += 1;
                            }
                            item.Isplaced = true;
                            gameBoard.UpdateGame();
                            break;

                        default:

                            break;
                    }
                }
            }
        }
    }
}
