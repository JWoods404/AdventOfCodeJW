using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW
{
    internal interface ICompartment
    {
        string CompartmentA { get; }
        string CompartmentB { get; }

        public char FindMatch();

    }
}
