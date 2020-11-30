using Project2.Models;

namespace Project2.Abstraction
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(Person person);
    }
}
