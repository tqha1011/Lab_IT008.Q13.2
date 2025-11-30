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
    public partial class Form5 : Form
    {

        public class SinhVien
        {
            public string MSSV {  get; set; }
            public string TenSv { get; set; }
            public string Nganh {  get; set; }
            public float Diem {  get; set; }
        }
        List<SinhVien> ds = new List<SinhVien>();
        public Form5()
        {
            InitializeComponent();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputSV inputForm = new InputSV();
            inputForm.ShowDialog();
            if(inputForm.DialogResult == DialogResult.OK)
            {
                string stt = (listView1.Items.Count + 1).ToString();
                SinhVien sv = new SinhVien();
                sv.MSSV = inputForm.StudentID;
                sv.TenSv = inputForm.StudentName;
                sv.Nganh = inputForm.StudentMajor;
                sv.Diem = float.Parse(inputForm.StudentPoint);
                ds.Add(sv);
                ShowList(ds);
            }
        }

        void ShowList(List<SinhVien> ds)
        {
            listView1.Items.Clear();
            for(int i=0; i<ds.Count; i++)
            {
                SinhVien sv = ds[i];
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add((i+1).ToString());
                item.SubItems.Add(sv.MSSV);
                item.SubItems.Add(sv.TenSv);
                item.SubItems.Add(sv.Nganh);
                item.SubItems.Add(sv.Diem.ToString());
                listView1.Items.Add(item);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SinhVien sv1 = new SinhVien();
            sv1.MSSV = "1";
            sv1.TenSv = "Nguyễn văn Bảo";
            sv1.Nganh = "Công nghệ thông tin";
            sv1.Diem = 5.6f; 
            ds.Add(sv1);

            
            SinhVien sv2 = new SinhVien();
            sv2.MSSV = "BH030343";
            sv2.TenSv = "Phạm Chí Bình";
            sv2.Nganh = "Công nghệ thông tin";
            sv2.Diem = 8.9f;
            ds.Add(sv2);

  
            ShowList(ds);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string key = toolStripTextBox1.Text.ToLower();
            List<SinhVien> list = new List<SinhVien>();
            foreach(SinhVien sv in ds)
            {
                if (sv.TenSv.ToLower().Contains(key))
                {
                    list.Add(sv);
                }
            }
            ShowList(list);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InputSV inputForm = new InputSV();
            inputForm.ShowDialog();
            if (inputForm.DialogResult == DialogResult.OK)
            {
                string stt = (listView1.Items.Count + 1).ToString();
                SinhVien sv = new SinhVien();
                sv.MSSV = inputForm.StudentID;
                sv.TenSv = inputForm.StudentName;
                sv.Nganh = inputForm.StudentMajor;
                sv.Diem = float.Parse(inputForm.StudentPoint);
                ds.Add(sv);
                ShowList(ds);
            }
        }
    }
}
