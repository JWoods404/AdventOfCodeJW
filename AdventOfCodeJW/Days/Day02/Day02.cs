using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCodeJW.Helpers;

namespace AdventOfCodeJW.Days.Day02
{
    internal class Day02 : IDay
    {
        public Day02(string[] input) => Input = input;

        public string[] Input { get; }

        public string GetAnswer()
        {
            long playerScore = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                var game = new RockPaperScissorsGame(Input[i][0], Input[i][2]);
                playerScore += game.getPlayerPoints(2);
            }

            return $"If the elf is trying to help, you will have {playerScore} points.";
        }
    }
}
