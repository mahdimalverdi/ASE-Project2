using Project2.Abstraction;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify(Person person)
        {
            foreach (var observer in observers)
            {
                observer.Update(person);
            }
        }
    }
}
