using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCodeJW.Helpers;

namespace AdventOfCodeJW.Days.Day03
{
    internal class Day03 : IDay
    {
        private long priorityScore;
        private long groupPriorityScore;
        private int elfId = 0;
        private List<ElfGroup> elfGroups= new();

        public Day03(string[] input) => Input = input;

        public string[] Input { get; }

        public string GetAnswer()
        {
            // use test data
            //Input = testData.Split("\r\n");

            ElfGroup? elfGroup = null;

            for (int i = 0; i < Input.Length; i++)
            {
                Elf elf = new Elf(++elfId);
                elf.Rucksack = new Rucksack(Input[i]);
                if (i % 3 == 0)
                {
                    elfGroup = new ElfGroup();
                    elfGroups.Add(elfGroup);
                }
                elfGroup?.Elves.Add(elf);
                elf.ElfGroup = elfGroup;
                var commonIndividualItem = elf.Rucksack.FindMatch();
                priorityScore += GetPriority(commonIndividualItem);
            }

            foreach (var group in elfGroups)
            {
                var badge = group.GetBadgeMatch();
                groupPriorityScore += GetPriority(badge);
            }

            return "Individual Score: " + priorityScore.ToString() + Environment.NewLine + "Group score: " + groupPriorityScore.ToString();
        }

        private int GetPriority(char c)
        {
            // use ASCII values
            // a-z = 1-26
            if (c >= 97 && c <= 122) return c - 96;
            // A-Z = 27-52
            return c - 38;
        }

        private string testData = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";
    }
}
