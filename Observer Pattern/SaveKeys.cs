using System;
using System.IO;
using System.IO.Compression;

namespace Observer_Pattern
{
    class SaveKeys : IObserver
    {

        string file = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "dados.txt.gz");

        public void Update(ISubject subject)
        {
            ConsoleKeyInfo key = (subject as KeyReader).ReadKey; //key.KeyChar

            File.AppendAllText(file, key.KeyChar + Environment.NewLine);

        }
    }
}
