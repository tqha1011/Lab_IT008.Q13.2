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
    public partial class Bai2 : KryptonForm
    {
        private Random random = new Random();
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Graphics g = e.Graphics;
            int x = random.Next(0, this.ClientSize.Width - 100);
            int y = random.Next(0, this.ClientSize.Height - 50);
            string text = "IT008";
            Font font = new Font("Arial", 18, FontStyle.Italic);
            g.DrawString(text, font, Brushes.Blue, x, y);
            font.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
