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
                    return new Days.Day01.Day01(input);
                case 2:
                    return new Days.Day02.Day02(input);
                case 3:
                    return new Days.Day03.Day03(input);
                case 4:
                    return new Days.Day04.Day04(input);
                case 5:
                    return new Days.Day05.Day05(input);
                case 6:
                    return new Days.Day06.Day06(input);
                case 7:
                    return new Days.Day07.Day07(input);
            }

            return null;
        }
    }
}
