using AdventOfCodeJW.Helpers;

namespace AdventOfCodeJW.Days.Day01
{
    internal class Day01 : IDay
    {
        IList<Elf> elves = new List<Elf>();
        private int elfId = 1;

        public string[] Input { get; }

        public Day01(string[] input) => Input = input;

        public string GetAnswer()
        {
            var sortedElves = GetElvesSorted();
            var part1 = sortedElves.First().ToString();

            var part2 = "Combined calories of top 3 elves: " + GetTotalCaloriesTopThreeElves(sortedElves).ToString();

            return "Top Elf:" + Environment.NewLine + part1 + Environment.NewLine + Environment.NewLine + part2;
        }

        private List<Elf> GetElvesSorted()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                var elf = new Elf(elfId);

                for (int j = i; j < Input.Length; j++)
                {
                    if (Input[j] == "")
                    {
                        i = j++;
                        break;
                    }
                    elf.AddCalories(int.Parse(Input[j]));
                }

                elfId++;
                elves.Add(elf);
            }

            return elves.OrderByDescending(e => e.TotalCalories).ToList();
        }

        private long GetTotalCaloriesTopThreeElves(List<Elf> elves)
        {
            return elves[0].TotalCalories + elves[1].TotalCalories + elves[2].TotalCalories;
        }

    }
}
