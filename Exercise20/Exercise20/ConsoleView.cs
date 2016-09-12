using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class ConsoleView : IView
    {
        public int GetInt(string prompt="")
        {
            Console.WriteLine(prompt);
            String number = Console.ReadLine();
            int n;
            bool isNumeric = int.TryParse(number, out n);
            return n;
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
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
