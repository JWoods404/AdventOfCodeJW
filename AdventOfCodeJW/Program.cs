// See https://aka.ms/new-console-template for more information
using AdventOfCodeJW;

var puzzleInputGetter = new PuzzleInputToString("Day1Input.txt");

Day1 day1 = new Day1(puzzleInputGetter.ConvertToString());
Console.WriteLine(day1.GetAnswer());
