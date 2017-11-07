using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SequentialCollections
{
    class SequentialCollectionsExercise
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise 2 (Queue)\n");
            Console.ResetColor();
            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();
                Console.WriteLine("From Queue: {0}", obj);
                Console.ReadLine();
            }


            //Exercise 2
            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exercise 2 (Stack)\n");
            Console.ResetColor();
            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
                Console.ReadLine();
            }
        }
    }
}
