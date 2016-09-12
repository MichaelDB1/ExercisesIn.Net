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
    public partial class FrmInputNumber : Form
    {
        public FrmInputNumber()
        {
            InitializeComponent();
        }

        private void FrmInputNumber_Activated(object sender, EventArgs e)
        {
            this.numericUpDown1.Focus();
        }
    }
}
