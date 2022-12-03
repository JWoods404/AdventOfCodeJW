using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCodeJW.Helpers;

namespace AdventOfCodeJW.Days
{
    internal class Day2 : IDay
    {
        public Day2(string input) => Input = input;

        public string Input { get; }

        public string GetAnswer()
        {
            long playerScore = 0;
            var inputArray = Input.Split("\r\n");

            for (int i = 0; i < inputArray.Length; i++)
            {
                var game = new RockPaperScissorsGame(inputArray[i][0], inputArray[i][2]);
                playerScore += game.getPlayerPoints(2);
            }

            return $"If the elf is trying to help, you will have {playerScore} points.";
        }
    }
}
