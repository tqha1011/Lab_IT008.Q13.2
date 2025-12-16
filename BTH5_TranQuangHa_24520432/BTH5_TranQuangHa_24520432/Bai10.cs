using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5_TranQuangHa_24520432
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float penwidth = cbbWidth.SelectedItem != null ? float.Parse(cbbWidth.SelectedItem.ToString()) : 5;
            using (Pen pen = new Pen(Color.Blue, penwidth))
            {
                if(cbbDashStyle != null)
                {
                    pen.DashStyle = (DashStyle)cbbDashStyle.SelectedValue;
                }
                if (cbbLineJoin != null)
                {
                    pen.LineJoin = (LineJoin)cbbLineJoin.SelectedValue;
                }
                if (cbbDashCap != null)
                {
                    pen.DashCap = (DashCap)cbbDashCap.SelectedValue;
                }
                if (cbbStartCap != null)
                {
                    pen.StartCap = (LineCap)cbbStartCap.SelectedValue;
                }
                if (cbbEndCap != null)
                {
                    pen.EndCap = (LineCap)cbbEndCap.SelectedValue;
                }
                Point[] points = {
                    new Point(20, 20),
                    new Point(120, 250),
                    new Point(350, 100)
                };

                g.DrawLines(pen, points);
            }

        }

        private void Bai10_Load(object sender, EventArgs e)
        {
            cbbDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cbbLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cbbDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cbbStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cbbEndCap.DataSource = Enum.GetValues(typeof(LineCap));
            for (int i = 0;i<= 20; i++)
            {
                cbbWidth.Items.Add(i.ToString());
            }
            cbbDashStyle.SelectedIndexChanged += new EventHandler(UpdateDrawing);
            cbbWidth.SelectedIndexChanged += new EventHandler(UpdateDrawing);
            cbbLineJoin.SelectedIndexChanged += new EventHandler(UpdateDrawing);
            cbbDashCap.SelectedIndexChanged += new EventHandler(UpdateDrawing);
            cbbStartCap.SelectedIndexChanged += new EventHandler(UpdateDrawing);
            cbbEndCap.SelectedIndexChanged += new EventHandler(UpdateDrawing);
        }

        private void UpdateDrawing(object sender, EventArgs e)
        {
            panelDraw.Invalidate();
        }


    }
}
