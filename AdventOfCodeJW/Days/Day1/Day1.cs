using AdventOfCodeJW.Helpers;

namespace AdventOfCodeJW.Days
{
    internal class Day1 : IDay
    {
        IList<Elf> elves = new List<Elf>();
        private int elfId = 1;

        public string Input { get; }

        public Day1(string input) => Input = input;

        public string GetAnswer()
        {
            var sortedElves = GetElvesSorted();
            var part1 = sortedElves.First().ToString();

            var part2 = "Combined calories of top 3 elves: " + GetTotalCaloriesTopThreeElves(sortedElves).ToString();

            return "Top Elf:" + Environment.NewLine + part1 + Environment.NewLine + Environment.NewLine + part2;
        }

        private List<Elf> GetElvesSorted()
        {
            var inputArray = Input.Split("\r\n");

            for (int i = 0; i < inputArray.Length; i++)
            {
                var elf = new Elf(elfId);

                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[j] == "")
                    {
                        i = j++;
                        break;
                    }
                    elf.AddCalories(int.Parse(inputArray[j]));
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
