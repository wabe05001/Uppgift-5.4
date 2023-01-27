using System;

namespace Uppgift5._4
{

   class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Walter", "Tim", "Adam", "Ameen", "Freja" };
            Array.Sort(namn);
            for(int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}