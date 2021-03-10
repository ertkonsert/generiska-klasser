using System;
using System.Collections.Generic;

namespace generiska_klasser_övningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wares = new Dictionary<string, int>();

            wares.Add("Apple", 10);
            wares.Add("Papaya", 20);
            wares.Add("Chunk o' meat", 100);
            wares.Add("Chunk o' meat (suspicious)", 1);

            Console.WriteLine("Welcome to the store! Take a look at all my beautiful wares:");

            foreach (KeyValuePair<string, int> ware in wares)
            {
                Console.WriteLine("{0} - {1}kr", ware.Key, ware.Value);

            }

            Console.WriteLine("Any you'd like to buy?");

            Console.ReadLine();
        }
    }
}
