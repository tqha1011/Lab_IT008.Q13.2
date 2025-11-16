using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace BTH4_TranQuangHa_24520432
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        int fontSize = 14;
        string font = "Tahoma";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripcbo1.Text = "Tahoma";
            toolStripcbo2.Text = "14";
            rtbInput.Font = new Font("Tahoma", 14);
            foreach (var font in FontFamily.Families)
            {
                toolStripcbo1.Items.Add(font.Name);
            }
            foreach (var size in new float[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 })
            {
                toolStripcbo2.Items.Add(size);
            }
        }

        private void updateFont()
        {
            rtbInput.Font = new Font(font, fontSize);
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt| Files (*.rtf)|*.rtf";
            openFileDialog.ShowDialog();
            string file = openFileDialog.FileName;
            string fileExtension = System.IO.Path.GetExtension(file);
            currentFilePath = file;
            if(fileExtension == ".txt")
            {
                rtbInput.LoadFile(file, RichTextBoxStreamType.PlainText);
            }
            else if(fileExtension == ".rtf")
            {
                rtbInput.LoadFile(file, RichTextBoxStreamType.RichText);
            }
        }

        private void toolStripcbo2_Click(object sender, EventArgs e)
        {
            
        }


        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            toolStripcbo1.Text = "Tahoma";
            toolStripcbo2.Text = 14.ToString();
            rtbInput.Font = new Font("Tahoma",14);
        }

        private void btnInDam_Click(object sender, EventArgs e)
        {
            if(rtbInput.Font.Bold)
            {
                rtbInput.Font = new Font(rtbInput.Font, rtbInput.Font.Style & ~FontStyle.Bold);
            }
            else
            {
                rtbInput.Font = new Font(rtbInput.Font, rtbInput.Font.Style | FontStyle.Bold);
            }
        }

        private void btnNghieng_Click(object sender, EventArgs e)
        {
           if(rtbInput.Font.Italic)
            {
                rtbInput.Font = new Font(rtbInput.Font, rtbInput.Font.Style & ~FontStyle.Italic);
            }
            else
            {
                rtbInput.Font = new Font(rtbInput.Font, rtbInput.Font.Style | FontStyle.Italic);
            }
        }

        private void toolStripcbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = toolStripcbo1.SelectedItem.ToString();
            updateFont();
        }

        private void toolStripcbo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = int.Parse( toolStripcbo2.SelectedItem.ToString());
            updateFont();
        }

        private void btnGachChan_Click(object sender, EventArgs e)
        {
            if(rtbInput.Font.Underline)
            {
                rtbInput.Font = new Font(rtbInput.Font, rtbInput.Font.Style & ~FontStyle.Underline);
            }
            else
            {
                rtbInput.Font = new Font(rtbInput.Font, rtbInput.Font.Style | FontStyle.Underline);
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(currentFilePath))
            {
                string fileExtension = System.IO.Path.GetExtension(currentFilePath);
                if(fileExtension == ".txt")
                {
                    rtbInput.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                else if(fileExtension == ".rtf")
                {
                    rtbInput.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                MessageBox.Show("Lưu file thành công!");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt| Files (*.rtf)|*.rtf";
                saveFileDialog.ShowDialog();
                string file = saveFileDialog.FileName;
                string fileExtension = System.IO.Path.GetExtension(file);
                currentFilePath = file;
                if(fileExtension == ".txt")
                {
                    rtbInput.SaveFile(file, RichTextBoxStreamType.PlainText);
                }
                else if(fileExtension == ".rtf")
                {
                    rtbInput.SaveFile(file, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            toolStripcbo1.Text = "Tahoma";
            toolStripcbo2.Text = 14.ToString();
            rtbInput.Font = new Font("Tahoma", 14);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                string fileExtension = System.IO.Path.GetExtension(currentFilePath);
                if (fileExtension == ".txt")
                {
                    rtbInput.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                else if (fileExtension == ".rtf")
                {
                    rtbInput.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                MessageBox.Show("Lưu file thành công!");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt| Files (*.rtf)|*.rtf";
                saveFileDialog.ShowDialog();
                string file = saveFileDialog.FileName;
                string fileExtension = System.IO.Path.GetExtension(file);
                currentFilePath = file;
                if (fileExtension == ".txt")
                {
                    rtbInput.SaveFile(file, RichTextBoxStreamType.PlainText);
                }
                else if (fileExtension == ".rtf")
                {
                    rtbInput.SaveFile(file, RichTextBoxStreamType.RichText);
                }
            }
        }
    }
}
