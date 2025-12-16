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
    public partial class Bai4 : Form
    {
        private int fontSize = 16;
        public Bai4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            if (colorDialog.Color != null)
            {
                btnColor.BackColor = colorDialog.Color;
                lblDraw.ForeColor = colorDialog.Color;
            }
        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeft.Checked)
            {
                lblDraw.TextAlign = ContentAlignment.TopLeft;
            }
            else
            {
                lblDraw.TextAlign= ContentAlignment.TopCenter;
            }
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFont.SelectedIndex != -1)
            {
                string fontName = cboFont.SelectedItem.ToString();
                float currentSize = lblDraw.Font.Size;
                FontStyle currentStyle = lblDraw.Font.Style;
                lblDraw.Font = new Font(fontName, currentSize, currentStyle);
            }
        }

        private void chkInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cboFont.Items.Add(font.Name);
            }

            for(int i = 1;i <= 72;i++)
            {
                cboSize.Items.Add(i);
            }
        }

        private void ChangeStyle(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (chkInDam.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (chkInNghieng.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (chkUnderline.Checked)
            {
                style |= FontStyle.Underline;
            }
            lblDraw.Font = new Font(lblDraw.Font.FontFamily, lblDraw.Font.Size, style);
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSize.SelectedIndex != -1)
            {
                string fontName = lblDraw.Font.Name;
                float currentSize = cboSize.SelectedItem.ToString() != "" ? float.Parse(cboSize.SelectedItem.ToString()) : 16;
                FontStyle currentStyle = lblDraw.Font.Style;
                lblDraw.Font = new Font(fontName, currentSize, currentStyle);
            }
        }

        private void chkCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCenter.Checked)
            {
                lblDraw.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                lblDraw.TextAlign= ContentAlignment.TopCenter;
            }
        }

        private void chkRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRight.Checked)
            {
                lblDraw.TextAlign = ContentAlignment.TopRight;
            }
            else
            {
                lblDraw.TextAlign = ContentAlignment.TopCenter;
            }
        }
    }
}
