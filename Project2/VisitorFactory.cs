using Project2.Abstraction;
using Project2.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class VisitorFactory
    {
        private const string Csv = "CSV";
        private const string Json = "JSON";
        private readonly string type;

        public VisitorFactory(string type)
        {
            this.type = type;
        }

        public IVisitor Create()
        {
            switch(type.ToUpperInvariant())
            {
                case Csv:
                    return new CsvVisitor();
                case Json:
                    return new JsonVisitor();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
