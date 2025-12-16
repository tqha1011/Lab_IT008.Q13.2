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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.Index >= 0)
            {
                string tenFont = listBox1.Items[e.Index].ToString();
                try
                {
                    using(Font font = new Font(tenFont, 16))
                    {
                        e.Graphics.DrawString(tenFont, font, Brushes.Black, e.Bounds);
                    }
                }
                catch(Exception ex)
                {
                    e.Graphics.DrawString(tenFont, e.Font, Brushes.Black, e.Bounds);
                }
            }
            e.DrawFocusRectangle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                listBox1.Items.Add(fontFamily.Name);
            }
        }
    }
}
