using AdventOfCodeJW.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Days.Day05
{
    internal class Day05 : IDay
    {
        public Day05(string[] input) => Input = input;

        public string[] Input { get; set; }

        public string GetAnswer()
        {
            return "Part 1: " + GetPart1Answer() + Environment.NewLine + "Part 2: " + GetPart2Answer();
        }

        private string GetPart1Answer()
        {
            //Input = testData.Split("\r\n"); // use test data

            var stackLists = PopulateStackLists();

            var moveStartIndex = Input.ToList().IndexOf(Input.ToList().First(x => x.StartsWith("move")));

            for (int i = moveStartIndex; i < Input.Length; i++)
            {
                var lineArray = Input[i].Split(' ');
                var numberOfMoves = int.Parse(lineArray[1]);
                while (numberOfMoves != 0)
                {
                    var tempChar = stackLists[int.Parse(lineArray[3]) - 1][0];
                    stackLists[int.Parse(lineArray[3]) - 1].RemoveAt(0);
                    stackLists[int.Parse(lineArray[5]) - 1].Insert(0, tempChar);
                    numberOfMoves--;
                }
            }

            string part1Answer = string.Empty;
            foreach (var stack in stackLists)
            {
                part1Answer += stack[0];
            }

            return part1Answer;
        }

        private string GetPart2Answer()
        {
            //Input = testData.Split("\r\n"); // use test data

            var stackLists = PopulateStackLists();

            var moveStartIndex = Input.ToList().IndexOf(Input.ToList().First(x => x.StartsWith("move")));

            for (int i = moveStartIndex; i < Input.Length; i++)
            {
                var lineArray = Input[i].Split(' ');
                var numberOfMoves = int.Parse(lineArray[1]);
                var tempCharList = new List<char>();
                while (numberOfMoves != 0)
                {
                    tempCharList.Add(stackLists[int.Parse(lineArray[3]) - 1][0]);
                    stackLists[int.Parse(lineArray[3]) - 1].RemoveAt(0);
                    numberOfMoves--;
                }
                stackLists[int.Parse(lineArray[5]) - 1].InsertRange(0, tempCharList);
            }

            string part2Answer = string.Empty;
            foreach (var stack in stackLists)
            {
                part2Answer += stack[0];
            }

            return part2Answer;
        }

        private List<List<char>> PopulateStackLists()
        {
            var stackListIndex = Input.ToList().IndexOf(Input.ToList().First(x => x.Any(y => int.TryParse(y.ToString(), out _))).ToString());

            var stackCount = int.Parse(Input.ToList()[stackListIndex].
                Trim().Last().ToString());

            List<List<char>> stackLists = new();
            for (int i = 0; i < stackCount; i++)
            {
                stackLists.Add(new List<char>());
            }

            for (int j = 0; j < stackListIndex; j++)
            {
                int stackNumber = 0;
                for (int k = 1; k < Input[0].Length; k += 4)
                {
                    if (Input[j][k] != ' ')
                    {
                        stackLists[stackNumber].Add(Input[j][k]);
                    }
                    stackNumber++;
                }
            }

            return stackLists;
        }

        private string testData = @"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";
    }
}
