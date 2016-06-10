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
            checkForBeginningOfString();
            checkForBeginningOfLine();
            checkForIgnoringSpecialCharacters();
            checkForLetters();
            Console.ReadLine();
        }

        private static void checkForLetters()
        {
            // \b Between the \w class and \W class
            // \B is the opposite of \b
            var pattern = "\\b";
            var matter = "I love French Fries!";
            var message = @"Testing \b";
            CheckForMultipleSuccess(pattern, matter, message);
        }

        private static void CheckForMultipleSuccess(string pattern, string matter, string message)
        {
            var regex = new Regex(pattern);
            var match = regex.Match(matter);
            while (match.Success)
            {
                Console.WriteLine($"{message} - Match is found at {match.Index} and is {match.Length} long");
                match = match.NextMatch();
            }
        }

        private static void checkForIgnoringSpecialCharacters()
        {
            //Regex Escape Can Ignore The Special Characters. 
            var pattern = @"^\(steven\)*";
            var matter = @"^\(steven\)*";
            var escapeRegex = Regex.Escape(pattern);
            var regex = new Regex(escapeRegex);
            var match = regex.Match(matter);
            if (match.Success)
            {
                Console.WriteLine("Testing Special Characters - It's a match and the special characters were ignored");
            }
        }

        private static void checkForBeginningOfLine()
        {
            // ?m denotes multiLine 
            // ^ denotes beginning of the string
            var pattern = "(?m)^Steven";
            var matter = "Nish\nSteven\nPrasanth";
            var message = "Testing ?m";
            checkForSuccess(pattern, matter, message);
        }

        private static void checkForBeginningOfString()
        {
            // \A denoted the beginning of a string.
            var pattern = "\\ASteven";
            var matter = "StevenPrasanth";
            var message = "Testing \\A";
            checkForSuccess(pattern, matter, message);
        }

        private static void checkForSuccess(string pattern, string matter, string message)
        {
            var regex = new Regex(pattern);
            var match = regex.Match(matter);
            if(match.Success)
            {
                Console.WriteLine($"{message} - Match is found at {match.Index} and is {match.Length} long");
            }
        }
    }
}
