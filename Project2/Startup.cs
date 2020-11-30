using Project2.Abstraction;
using Project2.Observers;
using System;

namespace Project2
{
    public class Startup
    {
        private readonly string path;
        private readonly Singleton singleton = Singleton.Instance;

        public Startup(string path)
        {
            this.path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void Configure()
        {
            AttachCsvObserve();
            AttachConsoleObserve();
        }

        private void AttachConsoleObserve()
        {
            Attach(new ConsoleObserve());
        }

        private void Attach(IObserver observer)
        {
            singleton.Subject.Attach(observer);
        }

        private void AttachCsvObserve()
        {
            Attach(new CsvObserve(path));
        }
    }
}
