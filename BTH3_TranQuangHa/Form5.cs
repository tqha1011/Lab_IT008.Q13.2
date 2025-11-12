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
    public partial class Form5 : KryptonForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNum1.Text, out int num1) || !int.TryParse(txtNum2.Text, out int num2))
            {
                MessageBox.Show("Nhap 2 so la so nguyen");
                return;
            }
            int result = num1 + num2;
            txtResult.Text = result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNum1.Text, out int num1) || !int.TryParse(txtNum2.Text, out int num2))
            {
                MessageBox.Show("Nhap 2 so la so nguyen");
                return;
            }
            int res = num1 - num2;
            txtResult.Text = res.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNum1.Text, out int num1) || !int.TryParse(txtNum2.Text, out int num2))
            {
                MessageBox.Show("Nhap 2 so la so nguyen");
                return;
            }
            int res = num1 * num2;
            txtResult.Text = res.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNum1.Text, out int num1) || !int.TryParse(txtNum2.Text, out int num2) || int.Parse(txtNum2.Text) == 0)
            {
                MessageBox.Show("Nhap 2 so la so nguyen va so thu hai != 0");
                return;
            }
            double res = (double)num1 / num2;
            txtResult.Text = res.ToString();
        }
    }
}
