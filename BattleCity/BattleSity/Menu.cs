using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleSity
{
    public class Menu
    {
        private ConsoleRender render;
        private int rowText;
        private int colText;
        private int choiseRow;
        private int rowDistance;
        private bool isExit;
        private uint levelNumber;

        public Menu()
        {
            int width = Data.GetWindowWidth();
            int height = Data.GetWindowHeight();
            this.render = new ConsoleRender(width, height);

            // set text menue position
            this.rowText = width / 9; 
            this.colText = height + 15;
            this.choiseRow = this.rowText; // set default choise position
            this.rowDistance = 2; // distance between printed rows

            isExit = false;
            this.levelNumber = 0;
        }

        public void Load()
        {
            //LevelEditorEngine.CreateLevel();

            //GameEngine game = new GameEngine();

            //game.Start();

            ShowStartMenu();
            ShowChoise();

            while (!isExit)
            {
                ChangeCaoise();

                Thread.Sleep(30);
            }
            
        }

        private void ChangeCaoise()
        {
            int maxLevel = Data.GetNumberOfLevels();
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();

            if (Console.KeyAvailable)
            {
                pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow &&
                                (rowText - rowDistance) == choiseRow && this.levelNumber > 1)
                {
                    this.levelNumber--;
                    ShowStartMenu();
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow &&
                                (rowText - rowDistance) == choiseRow && this.levelNumber < maxLevel)
                {
                    this.levelNumber++;
                    ShowStartMenu();
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (choiseRow > rowText - rowDistance)
                    {
                        HideChoise();
                        choiseRow -= rowDistance;
                        ShowChoise();
                    }
                }
                else if(pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (choiseRow < rowText + rowDistance * 2)
                    {
                        HideChoise();
                        choiseRow += rowDistance;
                        ShowChoise();
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Enter)
                {
                    EnterPressed();
                }
            }
        }

        private void EnterPressed()
        {
            if (rowText == choiseRow)
            {
                if (Data.GetNumberOfLevels() > 0)
                {
                    //isStartGame = true;
                    GameEngine game = new GameEngine(levelNumber);

                    game.Start();

                    render.BlackConsole();
                    ShowStartMenu();
                    ShowChoise();
                }
                
            }
            else if ((rowText + rowDistance) == choiseRow)
            {
                render.BlackConsole();
                // Save created level
                Element[,] elements = LevelEditorEngine.CreateLevel();

                if (IsSaveLevel())
                {
                    Data.SaveLevel(elements);
                }
                
                ShowStartMenu();
                ShowChoise();
            }
            else if ((rowText + rowDistance * 2) == choiseRow)
            {
                isExit = true;
                render.MenuItem(choiseRow + rowDistance,
                            colText - rowDistance, " ", ConsoleColor.Gray);
            }
        }

        private bool IsSaveLevel()
        {
            ShowSaveMenu();

            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();

            pressedKey = Console.ReadKey(true);

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            if (pressedKey.Key == ConsoleKey.Enter)
            {
                return true;
            }

            return false;
        }

        private void ShowSaveMenu()
        {
            render.BlackConsole();
            ConsoleColor color = ConsoleColor.Green;

            render.MenuItem(rowText, colText - 10, "To SAVE level press -> ENTER <-", color);
            render.MenuItem(rowText + rowDistance, colText - 15,
                            "To continue withuot saving press any key...", color);
        }

        private void HideChoise()
        {
            ConsoleColor color = ConsoleColor.Red;
            render.MenuItem(choiseRow, colText - rowDistance, " ", color);
        }

        private void ShowChoise()
        {
            ConsoleColor color = ConsoleColor.Red;
            render.MenuItem(choiseRow, colText - rowDistance, "@", color);
        }

        private void ShowStartMenu()
        {
            render.BlackConsole();
            ShowChoise();

            ConsoleColor color = ConsoleColor.Green;

            render.MenuItem(rowText - rowDistance, colText, "Level: " +
                            this.levelNumber.ToString().PadRight(3), color);
            render.MenuItem(rowText, colText, "Play game", color);
            render.MenuItem(rowText + rowDistance, colText, "Create level", color);
            render.MenuItem(rowText + rowDistance * 2, colText, "EXIT", color);

        }
    }
}
