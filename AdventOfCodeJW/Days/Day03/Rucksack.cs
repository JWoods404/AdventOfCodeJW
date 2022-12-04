using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Days.Day03
{
    internal class Rucksack : ICompartment
    {
        public Rucksack(string rucksackContents)
        {
            Contents= rucksackContents;
            var compartmentSize = rucksackContents.Length / 2;
            CompartmentA = rucksackContents.Substring(0, compartmentSize);
            CompartmentB = rucksackContents.Substring(compartmentSize, compartmentSize);
        }

        public string Contents { get; }

        public string CompartmentA { get; }

        public string CompartmentB { get; }

        public char FindMatch()
        {
            for (int i = 0; i < CompartmentA.Length; i++)
            {
                if (CompartmentB.Contains(CompartmentA[i]))
                {
                    return CompartmentA[i];
                }
            }

            return '\0';
        }
    }
}
