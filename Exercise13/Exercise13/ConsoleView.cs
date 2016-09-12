using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class ConsoleView : IView
    {
        public int GetInt(string prompt="")
        {
            Console.WriteLine(prompt);
            return Int32.Parse(Console.ReadLine());
        }

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
            Console.WriteLine("Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}
