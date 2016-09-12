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
    public partial class FrmRead : Form
    {
    

        public FrmRead()
        {
            InitializeComponent();

          
        }

        public FrmRead(FormMain frmMain)
        {
            this.Parent = frmMain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public string Get()
        {
            return this.textBox1.Text;
        }
        public void SetPrompt( string prompt)
        {
            this.Text = prompt;
        }

        private void FrmRead_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
