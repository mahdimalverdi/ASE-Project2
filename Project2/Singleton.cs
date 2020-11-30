using Project2.Abstraction;

namespace Project2
{
    public class Singleton
    {
        public static Singleton Instance { get; } = new Singleton();

        public ISubject Subject { get; } = new Subject();
        public ICommandReader CommandReader { get; } = new CommandReader();
    }
}
