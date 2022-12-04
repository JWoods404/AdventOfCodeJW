using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Days.Day2
{
    internal class RockPaperScissorsGame
    {
        private long player1Points;
        private long player2Points;

        public RockPaperScissorsGame(char player1move, char player2move)
        {
            DeterminePointsPart2(player1move, player2move);
        }

        public long getPlayerPoints(int playerNumber)
        {
            if (playerNumber == 1) return player1Points;
            return player2Points;
        }

        private void DeterminePoints(char player1move, char player2move)
        {
            switch (player1move)
            {
                case 'A': // p1 throws rock
                    player1Points += 1; // p1 move points
                    if (player2move == 'X') // rock, tie
                    {
                        player2Points += 1; // p2 move points

                        player1Points += 3;
                        player2Points += 3;
                    }
                    else if (player2move == 'Y') // paper, win player2
                    {
                        player2Points += 2; // p2 move points
                        player2Points += 6; // p2 win points
                    }
                    else if (player2move == 'Z') // scissors, loss player2
                    {
                        player2Points += 3; // p2 move points
                        player1Points += 6; // p1 win points
                    }
                    break;
                case 'B': // p1 throws paper
                    player1Points += 2; // p1 move points
                    if (player2move == 'X') // rock, loss player2
                    {
                        player2Points += 1; // p2 move points
                        player1Points+= 6;
                    }
                    if (player2move == 'Y') // paper, tie
                    {
                        player2Points += 2; // p2 move points

                        player1Points += 3;
                        player2Points += 3;
                    }
                    if (player2move == 'Z') // scissors, win player2
                    {
                        player2Points += 3; // p2 move points
                        player2Points += 6;
                    }
                    break;
                case 'C': // p1 throws scissors
                    player1Points += 3; // p1 move points
                    if (player2move == 'X') // rock, win player2
                    {
                        player2Points += 1; // p2 move points
                        player2Points+= 6;
                    }
                    if (player2move == 'Y') // paper, loss player2
                    {
                        player2Points += 2; // p2 move points
                        player1Points += 6;
                    }
                    if (player2move == 'Z') // scissors, tie
                    {
                        player2Points += 3; // p2 move points

                        player1Points += 3;
                        player2Points += 3;
                    }
                    break;
            }
        }

        private void DeterminePointsPart2(char player1move, char player2move)
        {
            switch (player1move)
            {
                case 'A': // p1 throws rock
                    player1Points += 1; // p1 move points
                    if (player2move == 'X') // need to lose
                    {
                        player2Points += 3; // p2 move points for scissors
                        player1Points += 6;
                    }
                    else if (player2move == 'Y') // need to tie
                    {
                        player2Points += 1; // p2 move points for rock

                        player1Points += 3;
                        player2Points += 3;
                    }
                    else if (player2move == 'Z') // need to win
                    {
                        player2Points += 2; // p2 move points for paper
                        player2Points += 6; // p1 win points
                    }
                    break;
                case 'B': // p1 throws paper
                    player1Points += 2; // p1 move points
                    if (player2move == 'X') // need to lose
                    {
                        player2Points += 1; // p2 move points for rock
                        player1Points += 6;
                    }
                    else if (player2move == 'Y') // need to tie
                    {
                        player2Points += 2; // p2 move points for paper

                        player1Points += 3;
                        player2Points += 3;
                    }
                    else if (player2move == 'Z') // need to win
                    {
                        player2Points += 3; // p2 move points for scissors
                        player2Points += 6; // p1 win points
                    }
                    break;
                case 'C': // p1 throws scissors
                    player1Points += 3; // p1 move points
                    if (player2move == 'X') // need to lose
                    {
                        player2Points += 2; // p2 move points for paper
                        player1Points += 6;
                    }
                    else if (player2move == 'Y') // need to tie
                    {
                        player2Points += 3; // p2 move points for scissors

                        player1Points += 3;
                        player2Points += 3;
                    }
                    else if (player2move == 'Z') // need to win
                    {
                        player2Points += 1; // p2 move points for rock
                        player2Points += 6; // p1 win points
                    }
                    break;
            }
        }
    }
}
