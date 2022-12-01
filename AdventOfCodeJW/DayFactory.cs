using AdventOfCodeJW.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW
{
    internal static class DayFactory
    {       
        public static IDay? GetDay(int dayId, string input)
        {
            switch (dayId)
            {
                case 1:
                    return new Day1(input);
                case 2:
                    return new Day2(input);
            }

            return null;
        }
    }
}
