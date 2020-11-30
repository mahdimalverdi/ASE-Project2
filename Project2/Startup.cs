using Project2.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class Startup
    {
        private readonly string path;

        public Startup(string path)
        {
            this.path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void Configure()
        {
            AttachCsvObserve();
            AttachConsoleObserve();
        }

        private static void AttachConsoleObserve()
        {
            var consoleObserve = new ConsoleObserve();
            Singleton.Instance.Subject.Attach(consoleObserve);
        }

        private void AttachCsvObserve()
        {
            var csvObserve = new CsvObserve(path);
            Singleton.Instance.Subject.Attach(csvObserve);
        }
    }
}
