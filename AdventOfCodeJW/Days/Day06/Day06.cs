using AdventOfCodeJW.Helpers;

namespace AdventOfCodeJW.Days.Day06
{
    internal class Day06 : IDay
    {
        public Day06(string[] input) => Input = input;
        public string[] Input { get; set; }

        public string GetAnswer()
        {
            //Input[0] = "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw";  // test data

            return GetStart(4) + Environment.NewLine + GetStart(14);
        }

        private string GetStart(int x)
        {
            for (int i = 0; i < Input[0].Length - x; i++)
            {
                var tempList = Input[0][i..(i + x)].ToList();
                var test = tempList.Distinct().ToList();
                if (tempList.Distinct().ToList().Count() == x)
                {
                    return (i + x).ToString();
                }
            }
            return string.Empty;
        }
    }
}
