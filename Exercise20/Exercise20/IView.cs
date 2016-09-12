using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    interface IView
    {
        void Start();
        void Stop();
        void Show<T>(T message);
        String GetString(string prompt);
        int GetInt(String prompt);
    }
}
