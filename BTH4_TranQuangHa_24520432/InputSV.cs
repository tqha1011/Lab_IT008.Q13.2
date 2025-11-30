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
    public partial class InputSV : Form
    {
        public InputSV()
        {
            InitializeComponent();
        }

        public string StudentID
        {
            get { return txtID.Text; }
        }

        public string StudentName
        {
            get { return txtName.Text; }
        }

        public string StudentMajor
        {
            get { return cboMajor.SelectedItem.ToString(); }
        }

        public string StudentPoint
        {
            get { return txtPoint.Text; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InputSV_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                cboMajor.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPoint.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
