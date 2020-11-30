using Project2.Abstraction;
using Project2.Models;
using System;
using System.IO;

namespace Project2.Observers
{
    public class FileObserve : IObserver
    {
        private const string LineSeparator = "\n";
        private readonly string path;
        private readonly IVisitor visitor;

        public FileObserve(string path, IVisitor visitor)
        {
            this.path = path ?? throw new ArgumentNullException(nameof(path));
            this.visitor = visitor ?? throw new ArgumentNullException(nameof(visitor));
        }

        public void Update(Person person)
        {
            var line = person.Serialize(visitor);

            File.AppendAllText(path, line + LineSeparator);
        }
    }
}
