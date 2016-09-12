using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class ConsoleView : View
    {
        public string GetSting(string prompt="")
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void Show<T>(T message)
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("starting");
        }

        public void Stop()
        {
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
