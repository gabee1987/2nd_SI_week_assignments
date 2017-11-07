using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupCollections
{
    class LookupCollectionsExercise
    {
        static void Main(string[] args)
        {
            // The Dictionary is case insensitive
            ListDictionary listDictionary = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            listDictionary["Estados Unidos"] = "United States of America";
            listDictionary["Canadá"] = "Canada";
            listDictionary["España"] = "Spain";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise 2 (Queue)\n");
            Console.ResetColor();
                Console.WriteLine("   English version                  Spain version \n");
            foreach (DictionaryEntry item in listDictionary)
            {
                Console.WriteLine("   {0,-25}        {1}", item.Value, item.Key);
            }
            Console.ReadLine();
        }
    }
}
