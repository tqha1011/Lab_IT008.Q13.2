using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5_TranQuangHa_24520432
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void Bai9_Load(object sender, EventArgs e)
        {
            cboShape.Items.Add("Circle");
            cboShape.Items.Add("Square");
            cboShape.Items.Add("Ellipse");
            cboShape.Items.Add("Pie");
            cboShape.Items.Add("Filled Circle");
            cboShape.Items.Add("Filled Square");
            cboShape.Items.Add("Filled Ellipse");
            cboShape.Items.Add("Filled Pie");
            cboShape.SelectedIndex = 0;
        }

        private void cboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Bai9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (cboShape.SelectedIndex == -1) return;
            string shape = cboShape.SelectedItem.ToString();
            Pen pen = new Pen(Color.Blue, 3);
            Brush brush = Brushes.DarkRed;
            Rectangle rectHinhVuong = new Rectangle(100, 100, 200, 200); 
            Rectangle rectHinhChuNhat = new Rectangle(50, 100, 300, 200);
            switch (shape)
            {
                case "Circle":
                    g.DrawEllipse(pen, rectHinhVuong);
                    break;
                case "Square":
                    g.DrawRectangle(pen, rectHinhVuong);
                    break;
                case "Ellipse":
                    g.DrawEllipse(pen, rectHinhChuNhat);
                    break;
                case "Pie":
                    g.DrawPie(pen, rectHinhVuong, 0, 150);
                    break;

                case "Filled Circle":
                    g.FillEllipse(brush, rectHinhVuong);
                    break;
                case "Filled Square":
                    g.FillRectangle(brush, rectHinhVuong);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(brush, rectHinhChuNhat);
                    break;
                case "Filled Pie":
                    g.FillPie(brush, rectHinhVuong, 0, 150);
                    break;
            }
        }
    }
}
