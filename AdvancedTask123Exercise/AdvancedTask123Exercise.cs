﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask123
{
    class AdvancedTask123Exercise
    {
        static List<FileInfo> FoundFiles;
        static List<FileSystemWatcher> watchers;


        static void Main(string[] args)
        {
            //ExampleExercise(args[0], args[1]);
            SearchForAFileAndWatchChanges();
            //FileWatcherExerciseVersion();
            Console.ReadLine();
        }


        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            try
            {
                if (currentDirectory.Exists)
                {
                    foreach (FileInfo file in currentDirectory.GetFiles())
                    {
                        if (file.Name == fileName)
                            foundFiles.Add(file);
                    }
                    foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
                    {
                        RecursiveSearch(foundFiles, fileName, dir);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n There is no directory named {0}", currentDirectory.FullName);
                    Console.ResetColor();
                }
            } catch (DirectoryNotFoundException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n The directory is not exists \n");
                Console.ResetColor();
                Console.WriteLine("\n Details: \n");
                Console.WriteLine(e.ToString());
            }
        }

        static void SearchForAFileAndWatchChanges()
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
                    Console.WriteLine(" {0}", file.FullName);
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

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n Now you can change the files to test the FileSystemWatcher.");
                Console.ResetColor();
                FileWatcher();
                Console.ReadLine();
            }
        }

        static void ExampleExercise(string fileNameInfo, string directoryNameInfo)
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

        static void FileWatcher()
        {
            watchers = new List<FileSystemWatcher>();

            foreach (FileInfo file in FoundFiles)
            {
                // Create a new FileSystemWatcher
                FileSystemWatcher newWatcher = new FileSystemWatcher(file.DirectoryName, file.Name);

                // Only watch text files.
                //newWatcher.Filter = "*.txt";

                // Add event handlers.
                newWatcher.Changed += new FileSystemEventHandler(OnChanged);
                newWatcher.Created += new FileSystemEventHandler(OnChanged);
                newWatcher.Deleted += new FileSystemEventHandler(OnChanged);
                newWatcher.Renamed += new RenamedEventHandler(OnRenamed);

                // Begin watching.
                newWatcher.EnableRaisingEvents = true;

                //Add watcher to a list
                watchers.Add(newWatcher);
            }
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Print out the details when a file is changed, created, or deleted.
            Console.Write(" File: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(e.FullPath);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" " + e.ChangeType + "\n");
            Console.ResetColor();
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Print out the details when a file is renamed.
            Console.Write(" File: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(e.OldFullPath);
            Console.ResetColor();
            Console.Write(" renamed to ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(e.FullPath);
            Console.ResetColor();
        }
    }
}
