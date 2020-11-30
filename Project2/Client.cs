using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class Client
    {
        private readonly Context context;

        public Client(Context context)
        {
            this.context = context;
        }

        public void Run()
        {
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
