using Project2.Abstraction;
using System;

namespace Project2
{
    class Program
    {
        private const string Path = "test.csv";

        static void Main(string[] args)
        {
            Configure();
            Run();
        }

        private static void Run()
        {
            var context = new Context();
            new Client(context).Run();
        }

        private static void Configure()
        {
            var visitor = GetVisitor();
            new Startup(Path, visitor).Configure();
        }

        private static IVisitor GetVisitor()
        {
            string visitorType = GetVisitorType();
            var visitor = new VisitorFactory(visitorType).Create();
            return visitor;
        }

        private static string GetVisitorType()
        {
            Console.Write("Please Enter Visitor Type(csv/json): ");
            var visitorType = Console.ReadLine();
            return visitorType;
        }
    }
}
