// See https://aka.ms/new-console-template for more information
using AdventOfCodeJW;

var dayNumber = 1;

var puzzleInputGetter = new PuzzleInputToString($"Day{dayNumber}Input.txt");

var day = DayFactory.GetDay(dayNumber, puzzleInputGetter.ConvertToString());
Console.WriteLine(day?.GetAnswer());
