using Project2.Abstraction;
using Project2.Models;
using System;
using System.IO;

namespace Project2.Observers
{
    public class CsvObserve : IObserver
    {
        private readonly string path;

        public CsvObserve(string path)
        {
            this.path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void Update(Person person)
        {
            var line = string.Join(",", person.FirstName, person.LastName, person.Age);

            File.AppendAllText(path, line + "\n");
        }
    }
}
