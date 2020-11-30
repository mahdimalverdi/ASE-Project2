using Project2.Abstraction;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2.Visitor
{
    public class CsvVisitor : IVisitor
    {
        private const string CellSeparator = ",";

        public string GetTitle(Person person)
        {
            var line = string.Join(CellSeparator, person.FirstName, person.LastName, person.Age);

            return line;
        }
    }
}
