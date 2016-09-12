using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    interface IView
    {
        void Start();
        void Stop();
        void Show<T>(T message);
        int GetInt(string prompt);
        string GetString(string prompt);
    }
}
