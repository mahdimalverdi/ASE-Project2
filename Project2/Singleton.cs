using Project2.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class Singleton
    {
        public static Singleton Instance { get; } = new Singleton();

        public ISubject Subject { get; } = new Subject();
        public ICommandReader CommandReader { get; } = new CommandReader();
    }
}
