using System;
using System.Collections.Generic;
using System.Text;

namespace Project2.Models
{
    public class Command
    {
        public Command(string type, string text)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public string Type { get; }
        public string Text { get; }
    }
}
