using AdventOfCodeJW.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Days.Day4
{
    internal class Day4 : IDay
    {
        private List<Elf> elves = new();
        public Day4(string[] input) => Input = input;

        public string[] Input { get; set; }

        public string GetAnswer()
        {
            //Input = testData.Split("\r\n");  // use test data

            for (int i = 0; i < Input.Length; i++)
            {
                Elf elf = new(i + 1);
                Elf elf2 = new(i + 2);
                var elfAssignments = Input[i].Split(',');
                for (int j = int.Parse(elfAssignments[0].Split('-')[0]); j <= int.Parse(elfAssignments[0].Split('-')[1]); j++)
                {
                    elf.SectionAssignment.Add(j);
                }
                for (int j = int.Parse(elfAssignments[1].Split('-')[0]); j <= int.Parse(elfAssignments[1].Split('-')[1]); j++)
                {
                    elf2.SectionAssignment.Add(j);
                }
                elves.Add(elf);
                elves.Add(elf2);
            }

            // Part 1
            int count = 0;

            for (int i = 0; i < elves.Count; i += 2)
            {
                if (elves[i].SectionAssignment.All(x => elves[i+1].SectionAssignment.Contains(x)) ||
                    elves[i+1].SectionAssignment.All(x => elves[i].SectionAssignment.Contains(x)))
                {
                    count++;
                }
            }

            // Part 2
            int count2 = 0;

            for (int i = 0; i < elves.Count; i += 2)
            {
                if (elves[i].SectionAssignment.Any(x => elves[i + 1].SectionAssignment.Contains(x)))
                {
                    count2++;
                }
            }

            return "part 1: " + count.ToString() + Environment.NewLine + "part 2: " + count2.ToString();
        }

        private string testData = @"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8";
    }
}
