using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW
{
    internal interface IDay
    {
        public string Input { get; }

        public string GetAnswer();
    }
}
