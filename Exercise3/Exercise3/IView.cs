using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    interface IView
    {
        void Start();
        void Stop();
        String GetString(String prompt);
        void Show<T>(T message);
    }
}
