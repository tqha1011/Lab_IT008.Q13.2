using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace BTH3_TranQuangHa
{
    public partial class Bai8 : Form
    {
        private List<TaiKhoan> taiKhoan = new List<TaiKhoan>();
        public Bai8()
        {
            InitializeComponent();
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            taiKhoan.Add(new TaiKhoan { MaTaiKhoan = "02130131", TenKhachHang = "Nguyễn Thái Công", DiaChi = "123 Trương Định P3 TP.HCM", SoTien = 2012012 });
            taiKhoan.Add(new TaiKhoan { MaTaiKhoan = "010292914", TenKhachHang = "Nguyễn Quốc Anh", DiaChi = "219/21 Trần Thái Tông Q1", SoTien = 1000000 });
            RefreshListView();
            TinhTongTien();
        }

        private void RefreshListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < taiKhoan.Count; i++)
            {
                TaiKhoan tk = taiKhoan[i];
                ListViewItem lvi = new ListViewItem((i + 1).ToString()); 
                lvi.SubItems.Add(tk.MaTaiKhoan);                           
                lvi.SubItems.Add(tk.TenKhachHang);                        
                lvi.SubItems.Add(tk.DiaChi);                              
                lvi.SubItems.Add(tk.SoTien.ToString());                   
                listView1.Items.Add(lvi);
            }
        }

        private ListViewItem SearchItem(string ID)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == ID)
                {
                    return item;
                }
            }
            return null;
        }
        private void TinhTongTien()
        {
            double tongTien = 0;
            foreach (TaiKhoan tk in taiKhoan)
            {
                tongTien += tk.SoTien;
            }
            txtTongTien.Text = tongTien.ToString("N0");
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtMoney.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string ID = txtID.Text;
            int soTien;
            if(!int.TryParse(txtMoney.Text, out soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ.");
                return;
            }

            ListViewItem existingItem = SearchItem(ID);
            if(existingItem == null)
            {
                TaiKhoan newAcc = new TaiKhoan
                {
                    MaTaiKhoan = ID,
                    TenKhachHang = txtName.Text,
                    DiaChi = txtAddress.Text,
                    SoTien = soTien
                };
                taiKhoan.Add(newAcc);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                TaiKhoan accToUpdate = taiKhoan.FirstOrDefault(tk => tk.MaTaiKhoan == ID);
                if(accToUpdate != null)
                {
                    accToUpdate.TenKhachHang = txtName.Text;
                    accToUpdate.DiaChi = txtAddress.Text;
                    accToUpdate.SoTien = soTien;
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
            }
            RefreshListView();
            TinhTongTien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            ListViewItem itemToDelete = SearchItem(id);
            if (itemToDelete == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    taiKhoan.RemoveAll(tk => tk.MaTaiKhoan == id);
                    RefreshListView();
                    TinhTongTien();
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtID.Text = selectedItem.SubItems[1].Text;
                txtName.Text = selectedItem.SubItems[2].Text;
                txtAddress.Text = selectedItem.SubItems[3].Text;
                txtMoney.Text = selectedItem.SubItems[4].Text;
            }
        }
    }
}
