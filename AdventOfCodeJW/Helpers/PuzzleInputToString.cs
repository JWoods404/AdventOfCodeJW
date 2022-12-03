using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeJW.Helpers
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
            if (path == null || !File.Exists(path)) return string.Empty;
            return File.ReadAllText(path);
        }
    }
}
