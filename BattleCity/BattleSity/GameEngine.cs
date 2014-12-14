
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleSity
{
    public class GameEngine
    {
        private bool havePlayerFire;
        private ConsoleRender render;
        private Element[,] level;
        private bool isExit;

        public GameEngine(uint levelNumber)
        {
            int width = Data.GetWindowWidth();
            int height = Data.GetWindowHeight();
            this.render = new ConsoleRender(width, height);

            this.level = Data.GetLevel(levelNumber);
            havePlayerFire = false;
            isExit = false;

        }

        public void Start()
        {
            
            render.Level(this.level);

            Tank player = new Tank(true, Data.GetWindowHeight() - 3, (Data.GetWindowWidth() / 2) - 3);
            render.Tank(player);
            Enemy enemy = new Enemy(false, 10, 15, '@');
            render.Tank(enemy);

            while (!isExit)
            {
                PlayerMove(player);
                
                Thread.Sleep(50);
            }
        }

        private void PlayerMove(Tank player)
        {
            Directions newDirection = Directions.Up;

            newDirection = ReadDirectionAndFire();

            if (newDirection != Directions.No)
            {
                player.Move(newDirection);
                render.Tank(player);
            }
        }

        private Directions ReadDirectionAndFire()
        {
            Directions direction = Directions.No;
            ConsoleKeyInfo presedKey = new ConsoleKeyInfo();

            if (Console.KeyAvailable)
            {
                presedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo fireKey = Console.ReadKey(true);

                    if (fireKey.Key == ConsoleKey.Spacebar)
                    {
                        havePlayerFire = true;
                    }
                }

                if (presedKey.Key == ConsoleKey.UpArrow)
                {
                    direction = Directions.Up;
                }
                else if (presedKey.Key == ConsoleKey.DownArrow)
                {
                    direction = Directions.Down;
                }
                else if (presedKey.Key == ConsoleKey.LeftArrow)
                {
                    direction = Directions.Left;
                }
                else if (presedKey.Key == ConsoleKey.RightArrow)
                {
                    direction = Directions.Right;
                }
                else if (presedKey.Key == ConsoleKey.Escape)
                {
                    isExit = true;
                }
            }

            return direction;
        }
    }
}
