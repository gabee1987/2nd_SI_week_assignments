using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedStorageDemo
{
    class IsolatedStorageDemoExercise
    {
        static void Main(string[] args)
        {
            // Exercise 4
            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStore);
            string contents = "";

            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs");
            userWriter.Close();

            // Exercise 5
            string[] files = userStore.GetFileNames("UserSettings.set");
            if (files.Length == 0)
            {
                Console.WriteLine("No files were found.");
            }
            else
            {
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStore);
                StreamReader userReader = new StreamReader(userStream);
                contents = userReader.ReadToEnd();

            }
            Console.Write("\n File content in isolated storage: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(contents);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
