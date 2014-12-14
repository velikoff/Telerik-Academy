using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleSity
{
    public static class LevelEditorEngine
    {
        private static int rows;
        private static int cols;
        private static int levelRow;
        private static int levelCol;
        private static int minRow;
        private static int maxRow;
        private static int minCol;
        private static int maxCol;
        private static int currentRow;
        private static int currentCol;
        private static int changeDistance;
        private static int eagleRowLevelCordinate;
        private static int eagleColLevelCordinate;

        private static Element element;
        private static ElementType currentElementType;
        private static ConsoleRender render;
        private static bool isSave;
        private static bool savePressed;
        private static bool isExit;

        private static Element[,] elements;

        public static Element[,] CreateLevel()
        {
            Initialisation();

            elements = new Element[rows, cols];

            // insert eagle
            int eagleRow = (rows - 1) * 3 - 1;
            int eagleCol = ((cols - 1) * 3) / 2;
            eagleRowLevelCordinate = rows - 2;
            eagleColLevelCordinate = cols / 2;
            Element eagle = new Element(ElementType.Eagle, eagleRow, eagleCol);
            elements[eagleRowLevelCordinate, eagleColLevelCordinate] = eagle;
            render.Element(eagle);


            return Create();
        }

        private static Element[,] Create()
        {
            while (true)
            {
                TakeAction();

                Save();

                if (isExit)
                {
                    break;
                }

                Thread.Sleep(10);
            }

            return elements;
        }

        private static void ShowElement()
        {
            render.Element(element);
        }

        private static void Save()
        {
            if (isSave)
            {
                if (element.Type == ElementType.Empty)
                {
                    elements[levelRow, levelCol] = null;
                }
                else
                {
                    elements[levelRow, levelCol] = element;
                }

                savePressed = true;
            }
        }

        private static void CreateElement()
        {
            element = new Element(currentElementType, currentRow, currentCol);
            ShowElement();
        }

        private static void TakeAction()
        {
            isSave = false;
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();

            if (Console.KeyAvailable)
            {
                int newLevelRow = levelRow;
                int newLevelCol = levelCol;

                pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    newLevelRow--;
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    newLevelRow++;
                }
                else if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    newLevelCol--;
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    newLevelCol++;
                }
                else if (pressedKey.Key == ConsoleKey.A)
                {
                    currentElementType++;

                    if (currentElementType == ElementType.Eagle)
                    {
                        currentElementType++;
                    }

                    if (currentElementType > ElementType.Empty)
                    {
                        currentElementType = ElementType.Wother;
                    }

                    CreateElement();
                }
                else if (pressedKey.Key == ConsoleKey.S)
                {
                    currentElementType--;

                    if (currentElementType == ElementType.Eagle)
                    {
                        currentElementType--;
                    }

                    if (currentElementType < 0)
                    {
                        currentElementType = ElementType.Empty;
                    }

                    CreateElement();
                }
                else if (pressedKey.Key == ConsoleKey.Spacebar)
                {
                    isSave = true;
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    isExit = true;
                }

                IsValidCordinats(newLevelRow, newLevelCol);
            }
        }

        private static void IsValidCordinats(int newLevelRow, int newLevelCol)
        {
            int newRow = newLevelRow * changeDistance + minRow;
            int newCol = newLevelCol * changeDistance + minCol;

            if (newRow >= minRow && newRow <= maxRow &&
                newCol >= minCol && newCol <= maxCol)
            {

                //if (newLevelRow == 15 && newLevelCol == 17)
                if (newLevelRow == eagleRowLevelCordinate && newLevelCol == eagleColLevelCordinate)
                {
                    return;
                }

                if (savePressed)
                {
                    savePressed = false;
                }
                else
                {
                    if (elements[levelRow, levelCol] != null)
                    {
                        render.Element(elements[levelRow, levelCol]);
                    }
                    else
                    {
                        render.DeleteElement(element);
                    }
                }

                levelRow = newLevelRow;
                levelCol = newLevelCol;

                currentRow = newRow;
                currentCol = newCol;


                CreateElement();
                ShowElement();
            }
        }

        private static void Initialisation()
        {
            int dimention = Data.GetElementDimention();
            int height = Data.GetWindowHeight();

            rows = height / dimention;
            cols = Data.GetWindowWidth() / dimention;


            minRow = 2;
            maxRow = height - dimention;
            minCol = 0;
            maxCol = Data.GetWindowWidth() - dimention;

            currentRow = minRow;
            currentCol = minCol;

            isExit = false;

            currentElementType = ElementType.Empty;

            changeDistance = Data.GetElementDimention();

            render = new ConsoleRender(Data.GetWindowWidth(), height);

            currentElementType = ElementType.Braket;
            element = new Element(currentElementType, minRow, minCol);
            ShowElement();
        }
    }
}
