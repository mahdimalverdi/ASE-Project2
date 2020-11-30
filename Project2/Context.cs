using Project2.Abstraction;
using System;

namespace Project2
{
    public class Context
    {
        private IParserStrategy parser;

        public Context()
        {
        }

        public Context(IParserStrategy parser)
        {
            this.parser = parser ?? throw new ArgumentNullException(nameof(parser));
        }

        public void SetStrategy(IParserStrategy strategy)
        {
            this.parser = strategy;
        }

        public void Parse(string text)
        {
            var people = this.parser.Parse(text);

            foreach (var person in people)
            {
                Singleton.Instance.Subject.Notify(person);
            }
        }
    }
}
