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
            string type = GetCommandType();
            var text = GetText();
            return new Command(type, text);
        }

        private static string GetCommandType()
        {
            Console.Write("Please Enter Command Type(csv/json/xml): ");
            var type = Console.ReadLine();
            return type;
        }

        private static string GetText()
        {
            Console.WriteLine("Please Enter Text: ");
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
