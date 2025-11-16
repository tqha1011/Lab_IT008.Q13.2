using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3_TranQuangHa
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }
            lblMoney.Text = "0";
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            button8.BackColor = Color.Yellow;
            button9.BackColor = Color.Yellow;
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Da co nguoi dat ghe nay");
            }
            else if(btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
            else if(btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int tongTien = 0;   
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    bool isNumber = int.TryParse(btn.Text, out int so);
                    if (isNumber && btn.BackColor == Color.Blue)
                    {
                        if(so >= 1 && so <= 5)
                        {
                            tongTien += 5000;
                        }
                        else if(so >= 6 && so <= 10)
                        {
                            tongTien += 6500;
                        }
                        else if(so >= 11 && so <= 15)
                        {
                            tongTien += 8000;
                        }
                        btn.BackColor = Color.Yellow;
                    }
                }
            }
            lblMoney.Text = tongTien.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
