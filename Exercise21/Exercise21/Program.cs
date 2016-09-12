using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            new Controller(new ConsoleView(), new reverseArray(), new Exercise21Test.ReverseArrayTest()).Go();
        }
    }
}
