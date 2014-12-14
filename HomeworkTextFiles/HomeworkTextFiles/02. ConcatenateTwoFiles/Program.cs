using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.ConcatenateTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFileName = "../../mytemp01.txt";//the dir of the .cs file
            string secondFileName = "../../mytemp02.txt"; //the dir of the .cs file
            string newFileName = "../../ConcatenatedFile.txt"; //the dir of the .cs file

            Archive(newFileName);

            CopyFile(firstFileName, secondFileName, newFileName);

            PrintFile(newFileName);
        }

        private static void PrintFile(string newFileName)
        {
            Console.Write("Do You want to read the concatenated file <y/n>: ");
            char answer = (char)Console.Read();

            if (answer == 'y')
            {
                using (StreamReader concatenated = new StreamReader(newFileName))
                {
                    string line = concatenated.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = concatenated.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("GoodBye");
            }
        }

        private static void Archive(string newFileName)
        {
            if (File.Exists(newFileName)) //if the file already exists we make an archive
            {
                string archiveName = newFileName.Remove(0, 6);
                string archive = "../../archive" + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Day + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + archiveName;
                File.Copy(newFileName, archive);
                File.Delete(newFileName);
            }

            File.Create(newFileName).Close();
        }

        private static void CopyFile(string firstFileName, string secondFileName, string newFileName)
        {
            using (StreamWriter writeToNewFile = new StreamWriter(newFileName))
            {
                using (StreamReader readFirstFile = new StreamReader(firstFileName))
                {
                    string line = readFirstFile.ReadLine();
                    while (line != null)
                    {
                        writeToNewFile.WriteLine(line);
                        line = readFirstFile.ReadLine();
                    }
                }

                using (StreamReader readSecondFile = new StreamReader(secondFileName))
                {
                    string line = readSecondFile.ReadLine();
                    while (line != null)
                    {
                        writeToNewFile.WriteLine(line);
                        line = readSecondFile.ReadLine();
                    }
                }
            }

            Console.WriteLine("The files are copied!");
        }
    }
}
