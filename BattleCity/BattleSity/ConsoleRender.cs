using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSity
{
    public class ConsoleRender
    {
        private int width;
        private int height;

        public ConsoleRender(int width, int height)
        {
            this.width = width;
            this.height = height;

            SetConsoleSetings();
        }

        private void SetConsoleSetings()
        {
            Console.WindowWidth = this.width;
            Console.BufferWidth = this.width;
            Console.WindowHeight = this.height;
            Console.BufferHeight = this.height;
            Console.CursorVisible = false;
        }

        public void Tank(Tank tank)
        {
            switch (tank.Direction)
            {
                case Directions.Up: DeleteTank(tank); DrowTank(tank);
                    break;
                case Directions.Down: DeleteTank(tank); DrowTank(tank);
                    break;
                case Directions.Left: DeleteTank(tank); DrowTank(tank);
                    break;
                case Directions.Right: DeleteTank(tank); DrowTank(tank);
                    break;
                default:
                    break;
            }
        }

        private void DrowTank(Tank tank)
        {
            Console.ForegroundColor = tank.Color;
            Console.BackgroundColor = ConsoleColor.White;

            string str = new string(tank.Sumbol, tank.Dimention);

            for (int row = 0; row < tank.Dimention; row++)
            {
                for (int col = 0; col < tank.Dimention; col++)
                {
                    Console.SetCursorPosition(tank.CurrentCol + col, tank.CurrentRow + row);
                    Console.Write(str[col]);
                }
                
            }

            Console.ResetColor();
        }

        private void DeleteTank(Tank tank)
        {
            Console.BackgroundColor = ConsoleColor.White;
            string str = new string(' ', tank.Dimention);
            Console.CursorVisible = false;

            for (int row = 0; row < tank.Dimention; row++)
            {
                for (int col = 0; col < tank.Dimention; col++)
                {
                    Console.SetCursorPosition(tank.OldCol + col, tank.OldRow + row);
                    Console.Write(str[col]);
                }
            }

        }

        public void Level(char[,] level)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < level.GetLength(0); row++)
            {
                for (int col = 0; col < level.GetLength(1); col++)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(level[row, col]);
                }
            }

            Console.ResetColor();
        }

        public void Level(Element[,] elements)
        {
            WhiteGameFild();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < elements.GetLength(0); row++)
            {
                for (int col = 0; col < elements.GetLength(1); col++)
                {
                    if (elements[row, col] != null)
                    {
                        Element(elements[row, col]);
                    }
                }
            }

            Console.ResetColor();
        }

        public void Element(Element element)
        {
            switch (element.Type)
            {
                case ElementType.Wother: DrowWater(element);
                    break;
                case ElementType.Braket: DrowBraket(element);
                    break;
                case ElementType.Steel: DrowSteel(element);
                    break;
                case ElementType.Eagle: DrowEagle(element);
                    break;
                case ElementType.Empty: DeleteElement(element);
                    break;
                default:
                    break;
            }
        }

        private void DrowEagle(Element eagle)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(eagle.Column, eagle.Row);
            Console.Write(" @ ");
            Console.SetCursorPosition(eagle.Column, eagle.Row + 1);
            Console.Write("<O>");
            Console.SetCursorPosition(eagle.Column, eagle.Row + 2);
            Console.Write("/ \\");
                

            Console.ResetColor();
        }

        private void DrowSteel(Element steel)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.White;

            string str = new string('#', steel.Dimention);

            for (int row = 0; row < steel.Dimention; row++)
            {
                for (int col = 0; col < steel.Dimention; col++)
                {
                    Console.SetCursorPosition(steel.Column + col, steel.Row + row);
                    Console.Write(str[col]);
                }

            }

            Console.ResetColor();
        }

        private void DrowWater(Element water)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;

            string str = new string('~', water.Dimention);

            for (int row = 0; row < water.Dimention; row++)
            {
                for (int col = 0; col < water.Dimention; col++)
                {
                    Console.SetCursorPosition(water.Column + col, water.Row + row);
                    Console.Write(str[col]);
                }

            }

            Console.ResetColor();
        }

        private void DrowBraket(Element braket)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;

            string str = new string('W' , braket.Dimention);

            for (int row = 0; row < braket.Dimention; row++)
            {
                for (int col = 0; col < braket.Dimention; col++)
                {
                    Console.SetCursorPosition(braket.Column + col, braket.Row + row);
                    Console.Write(str[col]);
                }

            }

            Console.ResetColor();
        }

        public void DeleteElement(Element element)
        {
            Console.BackgroundColor = ConsoleColor.White;
            string str = new string(' ', element.Dimention);
            Console.CursorVisible = false;

            for (int row = 0; row < element.Dimention; row++)
            {
                for (int col = 0; col < element.Dimention; col++)
                {
                    Console.SetCursorPosition(element.Column + col, element.Row + row);
                    Console.Write(str[col]);
                }
            }
        }

        public void MenuItem(int row, int col, string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.CursorVisible = false;

            Console.SetCursorPosition(col, row);

            Console.Write(text);

            Console.ResetColor();
        }

        public void BlackConsole()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;

            string str = new string(' ', width);

            for (int row = 0; row < height; row++)
            {
                Console.SetCursorPosition(0, row);

                Console.Write(str);
            }
        }

        public void WhiteGameFild()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;

            string str = new string(' ', width);

            for (int row = 2; row < height; row++)
            {
                Console.SetCursorPosition(0, row);

                Console.Write(str);
            }
        }
    }
}
