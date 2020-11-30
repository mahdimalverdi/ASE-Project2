using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Startup("test.csv").Configure();

            var context = new Context();

            while (true)
            {
                var command = Singleton.Instance.CommandReader.Read();
                var strategy = new ParserStrategyFactory(command.Type).Create();
                context.SetStrategy(strategy);
                context.Parse(command.Text);
            }
        }
    }
}
