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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
            lboxSubject.Items.Clear();
            lboxSubject.Items.AddRange(subjectlist.ToArray());
        }

        private List<string> subjectlist = new List<string>()
        {
            "Cơ sở dữ liệu",
            "Cơ sở DL NC",
            "PTTK Hệ thống thông tin",
            "Lập trình hướng đối tượng",
        };
        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ckbMale_CheckedChanged(object sender, EventArgs e)
        {
            ckbFemale.Enabled = !ckbMale.Checked;
        }

        private void ckbFemale_CheckedChanged(object sender, EventArgs e)
        {
            ckbMale.Enabled = !ckbFemale.Checked;
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            string selectedItem = lboxSubject.SelectedItem as string;
            if (selectedItem != null)
            {
                lboxSubject.Items.Remove(selectedItem);
                lboxRight.Items.Add(selectedItem);
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            string selectedItem = lboxRight.SelectedItem as string;
            if (selectedItem != null)
            {
                lboxRight.Items.Remove(selectedItem);
                lboxSubject.Items.Add(selectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text)
                || string.IsNullOrEmpty(cboMajor.Text) || (!ckbMale.Checked && !ckbFemale.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            int stt = lvStudent.Items.Count + 1;
            string mssv = txtID.Text;
            string name = txtName.Text;
            string major = cboMajor.Text;
            string gender = ckbMale.Checked ? "Nam" : "Nữ";
            int somon = lboxRight.Items.Count;
            ListViewItem lvi = new ListViewItem(stt.ToString());
            lvi.SubItems.Add(mssv);
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(major);
            lvi.SubItems.Add(gender);
            lvi.SubItems.Add(somon.ToString());
            lvStudent.Items.Add(lvi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            cboMajor.SelectedIndex = -1;
            ckbMale.Checked = false;
            ckbFemale.Checked = false;
            lboxRight.Items.Clear();
            lboxSubject.Items.Clear();
            lboxSubject.Items.AddRange(subjectlist.ToArray());
        }
    }
}
