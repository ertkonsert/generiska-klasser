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


            Console.WriteLine(wares["Apple"]);



            Console.ReadLine();
        }
    }
}
