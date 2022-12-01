using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW
{
    internal class PuzzleInputToString : IPuzzleInputToString
    {
        private string path;

        public PuzzleInputToString(string filename)
        {
            path = Path.Combine(Environment.CurrentDirectory, "Resources", filename);
        }

        public string ConvertToString()
        {
            return File.ReadAllText(path);
        }
    }
}
