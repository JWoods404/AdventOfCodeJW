using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Days.Day3
{
    internal class ElfGroup
    {
        public List<Elf> Elves { get; set; } = new();

        public char Badge { get; private set; }

        public char GetBadgeMatch()
        {
            // sort elves by amount of content in their rucksacks
            var sortedElves = Elves.OrderByDescending(e => e.Rucksack.Contents.Length).ToList();

            for (int i = 0; i < sortedElves.Last().Rucksack.Contents.Length; i++)
            {
                if (sortedElves[0].Rucksack.Contents.Contains(sortedElves.Last().Rucksack.Contents[i]) &&
                    sortedElves[1].Rucksack.Contents.Contains(sortedElves.Last().Rucksack.Contents[i]))
                {
                    Badge = sortedElves.Last().Rucksack.Contents[i];
                }
            }

            return Badge;
        }
    }
}
