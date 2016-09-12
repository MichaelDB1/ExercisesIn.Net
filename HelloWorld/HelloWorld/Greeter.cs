using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Greeter
    {
        protected String Name;
        public void SetName(String newName)
        {
            Name = newName;
        }
        public String Greet()
        {
            return "Hello " + Name;
        }
    }
}
