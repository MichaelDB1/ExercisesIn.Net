using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsViewDemo
{
    public class WinFormView : IView
    {

        protected Form Parent;
        protected FormOut  FrmOut = new FormOut();

        public void SetParent( Form parent)
        {
            Parent = parent;
        }
    
        public string In(string prompt)
        {
            
            FrmRead frmReader = new FrmRead();
            String value = "";
            frmReader.SetPrompt(prompt);

            if (frmReader.ShowDialog(Parent) == DialogResult.OK)
            {
                value = frmReader.Get();
            }
            frmReader.Dispose();
            return value;
        }


        public void Out(string message)
        {
            if (FrmOut == null)
            {
                Start();
            }
            this.FrmOut.Add(message);
        }


        public void Start()
        {
            FrmOut.MdiParent = Parent;
            FrmOut.Show();
            FrmOut.Clear();
        }

        public void Stop()
        {
            FrmOut.Dispose();
            Parent.Dispose();
        }
    }
}
