using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_but_really_6_ooops
{
    class Program
    {
        static void Main(string[] args)
        {
            new Controller(new ConsoleView(), new SumAndAverage()).Go();
        }
    }
}
