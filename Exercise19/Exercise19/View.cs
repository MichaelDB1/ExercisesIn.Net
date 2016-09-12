using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    interface View
    {
        void Start();
        void Stop();
        void Show<T>(T message);
        string GetString(string prompt);
        int GetInt(string prompt);
    }
}
