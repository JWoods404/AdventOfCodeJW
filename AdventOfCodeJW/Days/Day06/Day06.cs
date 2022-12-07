using AdventOfCodeJW.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Days.Day06
{
    internal class Day06 : IDay
    {
        public Day06(string[] input) => Input = input;
        public string[] Input { get; set; }

        public string GetAnswer()
        {
            Input[0] = "bvwbjplbgvbhsrlpgdmjqwftvncz";

            for (int i = 0; i < Input[0].Length - 4; i++)
            {
                var tempList = Input[0][i..(i + 4)].ToList();
                var test = tempList.Distinct().ToList();
                if (tempList.Distinct().ToList().Count() == 4)
                {
                    return (i+4).ToString();
                }
            }
            return string.Empty;
        }
    }
}
