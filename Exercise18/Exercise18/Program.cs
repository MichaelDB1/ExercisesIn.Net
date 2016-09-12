using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            new Controller(new ConsoleView(), new TestPalinDrome()).Go();
        }
    }
}
