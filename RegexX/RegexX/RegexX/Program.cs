using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexX
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = args[0];
            var matter = args[1];
            var regex = new Regex(pattern);
            var match = regex.Match(matter);
            Console.WriteLine(match.Success);
            Console.ReadLine();
        }
    }
}
