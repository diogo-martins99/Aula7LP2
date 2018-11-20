using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            KeyReader keyReader = new KeyReader();

            ScreenPrinter screenPrinter = new ScreenPrinter();

            keyReader.RegisterObserver(screenPrinter);

            keyReader.GetKeyInfo();

            keyReader.NotifyObservers();

            keyReader.RemoveObserver(screenPrinter);

            SaveKeys saveKeys = new SaveKeys();

            keyReader.RegisterObserver(saveKeys);

            keyReader.GetKeyInfo();

            keyReader.NotifyObservers();

            keyReader.RemoveObserver(saveKeys);

        }
    }
}
