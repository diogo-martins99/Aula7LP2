using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(string s);

    class Program
    {

        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            StrConcat concatener = new StrConcat("Mario: ");

            myDelegate = PrintUpper;
            myDelegate += PrintLower;
            myDelegate += concatener.ConcatAndPrint;

            myDelegate("It'sa me modafokas");

        }

        static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }


    }
}
