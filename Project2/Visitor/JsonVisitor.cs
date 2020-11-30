using Project2.Abstraction;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Project2.Visitor
{
    public class JsonVisitor : IVisitor
    {

        public string GetTitle(Person person)
        {
            var line = JsonSerializer.Serialize(person);

            return line;
        }
    }
}
