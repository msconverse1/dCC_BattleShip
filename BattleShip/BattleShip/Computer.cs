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
        public override void PlaceShip()
        {
            Random placement = new Random();


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
                    int dir = placement.Next(0, 1);
                    int x = placement.Next(0, 19);
                    System.Threading.Thread.Sleep(20);
                    int y = placement.Next(0, 19);
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
                    switch (dir)
                    {
                        case 0:
                            if ((x + item.Width) >= 19 || (y + item.Width) >= 19)
                            {
                                Console.WriteLine("Pick a new direction ship will not fit");
                                PlaceShip();
                            }
                            for (int i = 0; i < item.Width; i++)
                            {
                                if (gameBoard.Tile[x, y] != "E")
                                {
                                    Console.WriteLine("Can not place ship here one is already here!");
                                    PlaceShip();
                                }
                                gameBoard.Tile[x, y] = GetDescription(item.OccupationType);
                                y += 1;
                            }
                            item.Isplaced = true;
                            Console.Clear();
                            gameBoard.UpdateGame();
                            break;
                        case 1:
                            if (x + item.Width >= 19 || y + item.Width >= 19)
                            {
                                Console.WriteLine("Pick a new direction ship will not fit");
                                PlaceShip();
                            }
                            for (int i = 0; i < item.Width; i++)
                            {
                                if (gameBoard.Tile[x, y] != "E")
                                {
                                    Console.WriteLine("Can not place ship here one is already here!");
                                    PlaceShip();
                                }
                                gameBoard.Tile[x, y] = GetDescription(item.OccupationType);
                                x += 1;
                            }
                            item.Isplaced = true;
                            Console.Clear();
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
        }
    
}
