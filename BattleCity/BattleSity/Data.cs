using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace BattleSity
{
    public static class Data
    {
        private static int levelWidth = 80;
        private static int levelHeight = 50;

        private static int windowWidth = Console.LargestWindowWidth * 2 / 3;
        private static int windowHeight = Console.LargestWindowHeight * 2 / 3;

        private static int elementDimention = 3;

        private static string setingsPath = "setings.txt";

        public static char[,] GetLevel(int number)
        {
            char[,] level = new char[levelHeight, levelWidth];

            string path = "Levels\\level" + number.ToString() + ".txt";

            using (StreamReader reader = new StreamReader(path))
            {
                int row = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    for (int col = 0; col < line.Length; col++)
                    {
                        level[row, col] = line[col];
                    }

                    row++;
                }
            }

            return level;
        }

        public static Element[,] GetLevel(uint number)
        {
            Element[,] elements;
            string path = "Levels\\level" + number.ToString() + ".city";
            BinaryFormatter serializer = new BinaryFormatter();

            using (FileStream stream = File.OpenRead(path))
            {
                elements = (Element[,])serializer.Deserialize(stream);
            }

            return elements;
        }

        public static void SaveLevel(Element[,] elements)
        {
            int levelNumber = GetNumberOfLevels() + 1;

            SetNumberOfLevels(levelNumber);

            string path = "Levels\\level" + levelNumber.ToString() + ".city";
            BinaryFormatter serializer = new BinaryFormatter();

            using (FileStream stream = File.OpenWrite(path))
            {
                serializer.Serialize(stream, elements);
            }
        }

        private static List<string> ReadSetings()
        {
            List<string> setings = new List<string>();

            using (StreamReader reader = new StreamReader(setingsPath))
            {
                while (!reader.EndOfStream)
                {
                    string str = reader.ReadLine();
                    setings.Add(str);
                }
            }

            return setings;
        }

        private static void SaveSetings(List<string> setings)
        {
            using (StreamWriter writer = new StreamWriter(setingsPath))
            {
                for (int row = 0; row < setings.Count; row++)
                {
                    writer.WriteLine(setings[row]);
                }
            }
        }

        public static int GetNumberOfLevels()
        {
            List<string> setings = ReadSetings();

            string str = setings[0];

            int levels = int.Parse(str);

            return levels;
        }

        public static void SetNumberOfLevels(int levels)
        {
            List<string> setings = ReadSetings();

            setings[0] = levels.ToString();

            SaveSetings(setings);
        }

        public static int GetWindowWidth()
        {
            return windowWidth;
        }

        public static int GetWindowHeight()
        {
            return windowHeight;
        }

        public static int GetElementDimention()
        {
            return elementDimention;
        }
    }
}
