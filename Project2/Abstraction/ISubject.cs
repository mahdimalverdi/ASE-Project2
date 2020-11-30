using Project2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2.Abstraction
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(Person person);
    }
}
