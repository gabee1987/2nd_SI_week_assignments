using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask123
{
    class AdvancedTask123Exercise
    {
        static void Main(string[] args)
        {
            //exampleExercise(args[0], args[1]);
            searchForAFile();
            
        }

        static List<FileInfo> FoundFiles;

        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            try
            {
                foreach (FileInfo file in currentDirectory.GetFiles())
                {
                    if (file.Name == fileName)
                        foundFiles.Add(file);
                }
                foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
                {
                    if (currentDirectory.Exists)
                    {
                        RecursiveSearch(foundFiles, fileName, dir);
                    }
                    else
                    {
                        Console.WriteLine("There is no directory named {0}", currentDirectory.FullName);
                    }
                }
            } catch (DirectoryNotFoundException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThe directory is not exists \n");
                Console.ResetColor();
                Console.WriteLine("\nDetails: \n");
                Console.WriteLine(e.ToString());
            }
        }

        static void searchForAFile()
        {
            bool running = true;
            while (running)
            {
                string fileName;
                string directoryName;
                string exit = "";
                FoundFiles = new List<FileInfo>();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n With this console application you can search for files by filename and path.");
                Console.ResetColor();

                Console.Write("\n Enter the filename with extension you want to search for! e.g. example.txt\n ");
                fileName = Console.ReadLine();
                //exit = Console.ReadLine();
                Console.Write("\n Enter the path where you want to search for the < ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(fileName);
                Console.ResetColor();
                Console.Write(" > file! e.g. c:\\Example folder\\\n");
                directoryName = Console.ReadLine();
                //exit = Console.ReadLine();
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);

                RecursiveSearch(FoundFiles, fileName, directoryInfo);

                //Print out the number of files found
                Console.Write("\n Found ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(FoundFiles.Count);
                Console.ResetColor();
                Console.Write(" files.\n\n");


                //Print out the found files
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.ResetColor();
                foreach (FileInfo file in FoundFiles)
                {
                    Console.WriteLine("{0}", file.FullName);
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.ResetColor();


                Console.Write("\n Enter");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" \"search\" ");
                Console.ResetColor();
                Console.Write("if you want to search again or ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" \"exit\" ");
                Console.ResetColor();
                Console.Write("if you want to quit from the application. \n");
                exit = Console.ReadLine();
                if (exit == "exit")
                {
                    running = false;
                }
                else if (exit == "search")
                {
                    continue;
                }
            }
        }

        static void exampleExercise(string fileNameInfo, string directoryNameInfo)
        {
            string fileName = fileNameInfo;
            string directoryName = directoryNameInfo;
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            FoundFiles = new List<FileInfo>();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise 1 (Search pattern)\n");
            Console.ResetColor();
            //search recursively for the mathing files
            RecursiveSearch(FoundFiles, fileName, directoryInfo);
            //list the found files
            Console.WriteLine("Found {0} files.", FoundFiles.Count);
            foreach (FileInfo file in FoundFiles)
            {
                Console.WriteLine("{0}", file.FullName);
            }
            Console.ReadKey();
        }
    }
}
