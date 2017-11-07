using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class GenericCollectionsExercise
    {
        static void Main(string[] args)
        {
            //var countryCodes = new List<int>();
            //var countries = new List<string>();
            var countryCodes = new List<int>();
            List<string> countryCodesStrings = File.ReadAllLines(@"I:\CodeCool\.NET\SI_assignments\2nd_SI_week\GenericCollections\codes.txt").ToList();
            List<string> countries = File.ReadAllLines(@"I:\CodeCool\.NET\SI_assignments\2nd_SI_week\GenericCollections\countries.txt").ToList();
            //Dictionary<int, string> countryLookup = new Dictionary<int, string>();

            // Parse string codes to int and add them to a List<int>
            foreach (var countryCode in countryCodesStrings)
            {
                countryCodes.Add(ParseCountryCodes(countryCode));
            }

            // create a dictionary using .Zip and .ToDictionary
            var countryLookup = countryCodes.Zip(countries, (k, v) => new { Key = k, Value = v }).ToDictionary(x => x.Key, x => x.Value);

            /*
            for (int dictKey = 0; dictKey < countryCodes.Count; dictKey++)
            {
                int TempDuplicate = countryCodes[dictKey];
                countryLookup.Add(countryCodes[dictKey], countries[dictKey]);
            }
            */

            //print the elements of the dictionary
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise 5 (Dictionary)\n");
            Console.ResetColor();
            Console.WriteLine("   Country code                  Country \n");
            //Console.WriteLine("The 33 Code is for: {0}", countryLookup[33]);
            foreach (KeyValuePair<int, string> item in countryLookup)
            {
                //int code = item.Key;
                //string country = item.Value;
                //Console.WriteLine("Code {0,-25} =   {1}", code, country);
                Console.WriteLine("   {0,-25}     {1}", item.Key, item.Value);
            }
            
            
            var duplicates = countryCodes.GroupBy(a => a).SelectMany(ab => ab.Skip(1).Take(1)).ToList();
            duplicates.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

            /// <summary>
            /// Parse string input to int
            /// </summary>
            /// <param name="input"></param>
            /// <returns>int type</returns>
            static int ParseCountryCodes(string input)
            {
                int tempInt;
                if (Int32.TryParse(input, out tempInt))
                {
                    return tempInt;
                } else
                {
                return 1111;
                }
            }
    }
}
