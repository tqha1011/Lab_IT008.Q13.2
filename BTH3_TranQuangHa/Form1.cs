using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace BTH3_TranQuangHa
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLoad.Text = "Form is loaded";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtShow.Text = "Form is shown";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtClosing.Text = "Form is closing";
            MessageBox.Show("Form is closing");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtActivated.Text = "Form is activated";
            MessageBox.Show("Form is activated");
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtClosed.Text = "Form is closed";
            MessageBox.Show("Form is closed");
        }
    }
}
