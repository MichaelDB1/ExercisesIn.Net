using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ConsoleView : IView
    {


        public string GetString(string prompt="")
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
            Console.WriteLine("Starting now");
        }

        public void Stop()
        {
            Console.WriteLine("Press any key to finsih");
            Console.ReadKey();
        }
    }
}
