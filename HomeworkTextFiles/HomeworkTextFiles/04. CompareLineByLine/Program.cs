using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompareLineByLine
{
    class Program
    {
        static void Main()
        {
            string text1 = @"..\..\text1.txt";
            string text2 = @"..\..\text3.txt";

            try
            {
                StreamReader readFile1 = new StreamReader(text1);
                StreamReader readFile2 = new StreamReader(text2);

                using (readFile2)
                {
                    using (readFile1)
                    {
                        int equalsCount = 0;
                        int diffCount = 0;
                        string lineFile1 = readFile1.ReadLine();
                        string lineFile2 = readFile2.ReadLine();
                        while (lineFile1 != null && lineFile2 != null)
                        {
                            if (lineFile1.Equals(lineFile2))
                            {
                                equalsCount++;
                            }
                            else
                            {
                                diffCount++;
                            }
                            lineFile1 = readFile1.ReadLine();
                            lineFile2 = readFile2.ReadLine();
                        }
                        Console.WriteLine("Equal lines: {0}", equalsCount);
                        Console.WriteLine("Different lines: {0}", diffCount);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
