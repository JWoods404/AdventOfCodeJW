// See https://aka.ms/new-console-template for more information
using AdventOfCodeJW.Helpers;

bool isInt;
int dayNumber;
while (true)
{
	do
	{
		Console.Write("Enter the Day Number: ");
		isInt = int.TryParse(Console.ReadLine(), out dayNumber);
	} while (!isInt);

	var puzzleInputGetter = new PuzzleInputToString($"Day{dayNumber}Input.txt");

	var day = DayFactory.GetDay(dayNumber, puzzleInputGetter.ConvertToStringArray());
	Console.WriteLine(day?.GetAnswer() + Environment.NewLine); 
}
