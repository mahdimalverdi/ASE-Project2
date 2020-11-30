using Project2.Abstraction;
using Project2.Models;
using System;
using System.Text.Json;

namespace Project2.Observers
{
    internal class ConsoleObserve : IObserver
    {
        private readonly IVisitor visitor;

        public ConsoleObserve(IVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void Update(Person person)
        {
            var line = person.Serialize(visitor);

            Console.WriteLine(line);
        }
    }
}
