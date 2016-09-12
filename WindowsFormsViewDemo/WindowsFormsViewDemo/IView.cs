using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsViewDemo
{
    public interface IView
    {
        void SetParent(Form parent);
        void Start();
        void Stop();
        void Out(string message);
        string In(string prompt);
    }
}
