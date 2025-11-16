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
using System.Drawing;

namespace BTH3_TranQuangHa
{
    public partial class Bai3 : KryptonForm
    {
        private Random random = new Random();
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
