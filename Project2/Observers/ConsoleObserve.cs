using Project2.Abstraction;
using Project2.Models;
using System;
using System.Text.Json;

namespace Project2.Observers
{
    internal class ConsoleObserve : IObserver
    {
        public void Update(Person person)
        {
            var line = JsonSerializer.Serialize(person);

            Console.WriteLine(line);
        }
    }
}
