using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    interface View
    {
        void Start();
        void Stop();
        void Show<T>(T message);
        string GetSting(string prompt);
    }
}
