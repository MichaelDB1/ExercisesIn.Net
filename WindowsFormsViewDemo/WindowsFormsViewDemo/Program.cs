using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsViewDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IView view = new WinFormView();
            Exercise1Controller ex = new Exercise1Controller(view);
            FormMain f = new FormMain( view, ex );
            
            Application.Run( f );
        }
    }
}
