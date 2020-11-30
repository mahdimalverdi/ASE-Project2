using Project2.Abstraction;
using Project2.Models;
using System;
using System.Collections.Generic;

namespace Project2
{
    internal class CommandReader : ICommandReader
    {
        private const string EndOfFile = "EOF";
        private const string EndLine = "\n";

        public Command Read()
        {
            var type = Console.ReadLine();
            var text = GetText();
            return new Command(type, text);
        }

        private static string GetText()
        {
            var lines = GetLines();
            var text = string.Join(EndLine, lines);
            return text;
        }

        private static IEnumerable<string> GetLines()
        {
            string newLine;
            while (!(newLine = Console.ReadLine()).ToUpperInvariant().Equals(EndOfFile))
            {
                yield return newLine;
            }
        }
    }
}
