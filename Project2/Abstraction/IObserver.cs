using Project2.Models;

namespace Project2.Abstraction
{
    public interface IObserver
    {
        void Update(Person person);
    }
}
