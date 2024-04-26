using ObserverPatternDemo;
using System;
using System.Collections.Generic;

namespace ObserverPatternDemo
{
    // Subject (Observable) class
    public class Subject
    {
        private static Subject instance;

        // List to hold the observers
        private List<IObserver> observers = new List<IObserver>();

        // Private constructor to prevent external instantiation
        private Subject() { }

        // Method to get the singleton instance
        public static Subject GetInstance()
        {
            if (instance == null)
            {
                instance = new Subject();
            }
            return instance;
        }

        // Method to subscribe an observer
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        // Method to unsubscribe an observer
        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Method to notify all observers with new data
        public void NotifyObservers(string data)
        {
            foreach (var observer in observers)
            {
                observer.Update(data);
            }
        }
    }
}
