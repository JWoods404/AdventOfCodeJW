using AdventOfCodeJW.Days;

namespace AdventOfCodeJW.Helpers
{
    internal static class DayFactory
    {
        public static IDay? GetDay(int dayId, string[] input)
        {
            switch (dayId)
            {
                case 1:
                    return new Days.Day1.Day1(input);
                case 2:
                    return new Days.Day2.Day2(input);
                case 3:
                    return new Days.Day3.Day3(input);
                case 4:
                    return new Days.Day4.Day4(input);
            }

            return null;
        }
    }
}
