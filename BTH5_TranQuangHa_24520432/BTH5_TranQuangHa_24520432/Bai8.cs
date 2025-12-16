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
    public partial class Bai8 : Form
    {
        Timer t = new Timer();
        int width = 400,height = 400,secHand = 140,minHand = 110,hourHand = 80;

        public Bai8()
        {
            InitializeComponent();
            this.Size = new Size(width + 50, height + 50);
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;

            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Bai8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            var state = g.Save();
            for (int i = 0; i <= 12; i++)
            {
                g.FillEllipse(Brushes.White, -5, -140, 10, 10);
                g.RotateTransform(30);
            }
            g.Restore(state);

            DateTime dt = DateTime.Now;

            state = g.Save();
            g.RotateTransform((dt.Hour % 12 + dt.Minute / 60f) * 30);
            Point[] hourHandPoints = { new Point(0, 20), new Point(-10, 0), new Point(0, -hourHand), new Point(10, 0) };
            g.DrawPolygon(Pens.White, hourHandPoints);
            g.Restore(state);

            state = g.Save();
            g.RotateTransform((dt.Minute + dt.Second / 60f) * 6);
            Point[] minuteHandPoints = { new Point(0, 20), new Point(-8, 0), new Point(0, -minHand), new Point(8, 0) };
            g.DrawPolygon(Pens.White, minuteHandPoints);
            g.Restore(state);

            state = g.Save();
            g.RotateTransform(dt.Second * 6);
            g.DrawLine(new Pen(Color.White, 2), 0, 0, 0, -secHand);
            g.Restore(state);
        }
    }
}
