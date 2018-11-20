using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class ScreenPrinter : IObserver
    {
        public void Update(ISubject subject)
        {
            ConsoleKeyInfo key = (subject as KeyReader).ReadKey;

            Console.WriteLine("Pressed Key: " + key.KeyChar);
        }
    }
}
