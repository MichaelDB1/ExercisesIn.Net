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
    public partial class FormOut : Form
    {
        public FormOut()
        {
            InitializeComponent();
        }
        public void Add( string message)
        {
            this.LbxShow.Items.Add(message);
        }
        public void Clear()
        {
            this.LbxShow.Items.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
