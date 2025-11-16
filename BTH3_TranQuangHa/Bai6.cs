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
    public partial class Bai6 : Form
    {
        private double num1 = 0;
        string operation = "";
        bool isOperationClicked = false;
        double res = 0;
        public Bai6()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            double.TryParse(lblOutput.Text, out double lastNum);

            // 1. Cập nhật label phụ lần cuối (Tùy chọn)
            lblShow.Text += lastNum.ToString() + " =";

            // 2. Thực hiện phép tính cuối cùng
            // Nếu chưa nhấn phép toán nào (chỉ gõ 5 rồi nhấn =)
            if (operation == "")
            {
                res = lastNum;
            }
            else // Nếu có phép toán (ví dụ: 5 + 2 =)
            {
                switch (operation)
                {
                    case "+": res = res + lastNum; break;
                    case "-": res = res - lastNum; break;
                    case "*": res = res * lastNum; break;
                    case "/": 
                        if(lastNum != 0)
                        {
                            res = res / lastNum; 
                        }
                        else
                        {
                            lblOutput.Text = "Cannot divide by zero";
                            res = 0;
                            operation = "";
                            isOperationClicked = true;
                            lblShow.Text = "";
                            return;
                        }
                        break;
                }
            }

            // 3. Hiển thị kết quả cuối cùng
            lblOutput.Text = res.ToString();

            // 4. Reset máy tính về trạng thái sạch
            operation = "";
            isOperationClicked = true;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Krypton.Toolkit.KryptonButton clicked = (Krypton.Toolkit.KryptonButton)sender;
            string number = clicked.Text;
            if(lblOutput.Text == "0" || isOperationClicked)
            {
                lblOutput.Text = number;
                isOperationClicked = false;
            }
            else
            {
                lblOutput.Text += number;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "0";
            res = 0;
            lblShow.Text = "";
            operation = "";
            isOperationClicked = false;
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Krypton.Toolkit.KryptonButton clicked = (Krypton.Toolkit.KryptonButton)sender;
            string newoperation = clicked.Text;
            double.TryParse(lblOutput.Text, out num1);
            if (isOperationClicked)
            {
                operation = newoperation;
                lblShow.Text = res + " " + operation;
                return;
            }
            isOperationClicked = true;
            if(operation == "")
            {
                res = num1;
            }
            else
            {
                switch (operation)
                {
                    case "+": res += num1; break;
                    case "-": res -= num1; break;
                    case "*": res *= num1; break;
                    case "/": 
                        if(num1 != 0)
                        {
                            res /= num1; 
                        }
                        else
                        {
                            lblOutput.Text = "Cannot divide by zero";
                            res = 0;
                            operation = "";
                            isOperationClicked = true;
                            lblShow.Text = "";
                            return;
                        }
                        break;
                }
            }
            lblOutput.Text = res.ToString();
            operation = newoperation;
            lblShow.Text = res + " " + operation;
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }
    }
}
