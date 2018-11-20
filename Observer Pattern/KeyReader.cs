using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class KeyReader : ISubject
    {
        public ConsoleKeyInfo ReadKey { get; private set; }

        private readonly HashSet<IObserver> set;

        public KeyReader()
        {
            set = new HashSet<IObserver>();
        }

        public void RegisterObserver(IObserver obs)
        {
            set.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            set.Add(obs);
        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in set)
            {
                obs.Update(this);
            }
        }

        public void GetKeyInfo()
        {
            do
            {
                ReadKey = Console.ReadKey();
                NotifyObservers();
            }
            while (ReadKey.Key != ConsoleKey.Escape);
        }
    }
}
