using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Days.Day03
{
    internal interface ICompartment
    {
        string CompartmentA { get; }
        string CompartmentB { get; }

        public char FindMatch();

    }
}
