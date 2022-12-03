// See https://aka.ms/new-console-template for more information
using AdventOfCodeJW.Helpers;

bool isInt;
int dayNumber;
do
{
	Console.Write("Enter the Day Number: ");
	isInt = int.TryParse(Console.ReadLine(), out dayNumber); 
} while (!isInt);

var puzzleInputGetter = new PuzzleInputToString($"Day{dayNumber}Input.txt");

var day = DayFactory.GetDay(dayNumber, puzzleInputGetter.ConvertToString());
Console.WriteLine(day?.GetAnswer());
