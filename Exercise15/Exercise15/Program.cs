using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            new Controller(new ConsoleView(), new Tribonaccics()).Go();
        }
    }
}
