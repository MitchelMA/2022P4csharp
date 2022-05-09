using System;
using System.Collections.Generic;

namespace ListOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string>()
            {
                "uil",
                "kraai",
                "hond",
                "papegaai"
            };
            List<string> birds2 = new List<string>()
            {
                "meeuw",
                "duif"
            };
            birds.AddRange(birds2);
            int hondIndex = birds.IndexOf("hond");
            if (hondIndex != -1)
            { 
                birds.RemoveAt(hondIndex);
            }
            int kipIndex = birds.IndexOf("kip");
            if (kipIndex != -1)
            {
                birds.RemoveAt(kipIndex);
            }
            foreach (var bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}
