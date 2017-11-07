using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 3
            Hashtable lookup = new Hashtable();
            lookup["0"] = "Zero";
            lookup["1"] = "One";
            lookup["2"] = "Two";
            lookup["3"] = "Three";
            lookup["4"] = "Four";
            lookup["5"] = "Five";
            lookup["6"] = "Six";
            lookup["7"] = "Seven";
            lookup["8"] = "Eight";
            lookup["9"] = "Nine";

            string ourNumber = "888-555-1212";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise 2 (Queue)\n");
            Console.ResetColor();
            Console.WriteLine(ourNumber + "\n");
            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if(lookup.ContainsKey(digit))
                {
                    Console.WriteLine("Key: {0}  Value: {1}", c.ToString(), lookup[digit]);
                }
            }
                    Console.ReadLine();
        }
    }
}
