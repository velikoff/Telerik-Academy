using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.EnterLineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFileName = "../../mytemp.txt"; //the dir of the .cs file
            string newFileName = "../../ConcatenatedFile.txt"; //the dir of the .cs file

            Archive(newFileName);

            AddLines(firstFileName, newFileName);

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

        private static void AddLines(string firstFileName, string newFileName)
        {
            using (StreamWriter destinationFile = new StreamWriter(newFileName))
            {
                using (StreamReader sourceFile = new StreamReader(firstFileName))
                {
                    string line = sourceFile.ReadLine();
                    int countLine = 1;
                    while (line != null)
                    {
                        destinationFile.Write("Line: {0} ", countLine);
                        destinationFile.WriteLine(line);
                        line = sourceFile.ReadLine();
                        countLine++;
                    }
                }
            }

            Console.WriteLine("Manipulation ready!");
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
    }
}
