﻿using System.Text.RegularExpressions;

namespace AdventOfCodeJW
{
    class Elf
    {
        private long totalCalories = 0;

        public Elf(int id)
        {
            ElfId = id;
        }

        public ElfGroup ElfGroup { get; set; }

        public Rucksack Rucksack { get; set; }

        public int ElfId { get; }
        public long TotalCalories
        {
            get
            {
                return totalCalories;
            }
        }


        public void AddCalories(long calories)
        {
            totalCalories += calories;
        }

        public override string ToString()
        {
            return "Elf Id: " + ElfId + Environment.NewLine + "Calories: " + totalCalories;
        }
    }
}
