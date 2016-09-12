using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    interface IView
    {
        void Start();
        void Stop();
        String GetString(String prompt);
        Int32 GetInt(String prompt);
        void Show<T>(T message);
    }
}
