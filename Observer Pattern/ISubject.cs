using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    interface ISubject
    {
        void RegisterObserver(IObserver obs);

        void RemoveObserver(IObserver obs);

        void NotifyObservers();

    }
}
