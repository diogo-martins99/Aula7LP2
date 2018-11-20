using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    struct StrConcat
    {
        private string myStr;

        public StrConcat(string str)
        {
            myStr = str;
        }

        public void ConcatAndPrint(string str)
        {
            Console.WriteLine(myStr + str);
        }
    }
}
