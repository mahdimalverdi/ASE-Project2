using Project2.Abstraction;
using Project2.Observers;
using Project2.Visitor;
using System;

namespace Project2
{
    public class Startup
    {
        private readonly string path;
        private readonly IVisitor visitor;
        private readonly Singleton singleton = Singleton.Instance;

        public Startup(string path, IVisitor visitor)
        {
            this.path = path ?? throw new ArgumentNullException(nameof(path));
            this.visitor = visitor ?? throw new ArgumentNullException(nameof(visitor));
        }

        public void Configure()
        {
            AttachCsvObserve(visitor);
            AttachConsoleObserve(visitor);
        }

        private void AttachConsoleObserve(IVisitor visitor)
        {
            Attach(new ConsoleObserve(visitor));
        }

        private void Attach(IObserver observer)
        {
            singleton.Subject.Attach(observer);
        }

        private void AttachCsvObserve(IVisitor visitor)
        {
            Attach(new FileObserve(path, visitor));
        }
    }
}
