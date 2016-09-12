using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsViewDemo
{
    public partial class FormMain : Form
    {

        protected IView View;
        protected ExerciseController Ex1;
        FormOut Shower = new FormOut();
        
        public FormMain()
        {
            InitializeComponent();
            View.Start();
        }

        public FormMain(IView view, ExerciseController ex1)
        {
            View = view;
            Ex1 = ex1;
            InitializeComponent();
            View.SetParent(this);
            View.Start();
        }


        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Stop();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ex1.Go();
        }
    }
}
