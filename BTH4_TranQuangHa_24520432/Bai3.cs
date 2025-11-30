using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_TranQuangHa_24520432
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.stretchToFit = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3|All Files|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh/mm/ss");
        }
    }
}
