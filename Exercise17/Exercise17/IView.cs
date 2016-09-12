using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    interface IView
    {
        void Start();
        void Stop();
        Int32 GetInt(String prompt);
        String GetString(String prompt);
        void Show<T>(T message);
    }
}
