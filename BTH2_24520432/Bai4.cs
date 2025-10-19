using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    internal class Bai4
    {
        void nhapPhanSo(out int tuSo, out int mauSo, string phanSoName)
        {
            do
            {
                Console.WriteLine($"Nhap tu so phan so {phanSoName}");
            } while (!int.TryParse(Console.ReadLine(), out tuSo));
            do
            {
                Console.WriteLine($"Nhap mau so phan so {phanSoName} (!=0)");
            } while (!int.TryParse(Console.ReadLine(), out mauSo) || mauSo == 0);
        }

        void timPhanSoLonNhat(List<PhanSo> danhSachPhanSo)
        {
            if (danhSachPhanSo.Count == 0)
            {
                Console.WriteLine("Danh sach phan so rong");
                return;
            }
            PhanSo maxPhanSo = danhSachPhanSo[0];
            for(int i = 1; i < danhSachPhanSo.Count; i++)
            {
                if (danhSachPhanSo[i] > maxPhanSo)
                {
                    maxPhanSo = danhSachPhanSo[i];
                }
            }
            Console.WriteLine("Phan so lon nhat trong danh sach la: " + maxPhanSo.ToString());
        }

        void sapxepDanhSachPhanSo(List<PhanSo> danhSachPhanSo)
        {
            for(int i = 0; i < danhSachPhanSo.Count - 1; i++)
            {
                for(int j = i + 1; j < danhSachPhanSo.Count; j++)
                {
                    if (danhSachPhanSo[i] > danhSachPhanSo[j])
                    {
                        PhanSo temp = danhSachPhanSo[i];
                        danhSachPhanSo[i] = danhSachPhanSo[j];
                        danhSachPhanSo[j] = temp;
                    }
                }
            }
        }

        void xuatDanhSach(List<PhanSo> danhSach)
        {
            for(int i = 0; i < danhSach.Count; i++)
            {
                Console.Write(danhSach[i].ToString() + "");
            }
            Console.WriteLine();
        }
        public void runPhepTinh()
        {
            int tuSo1, mauSo1,tuSo2,mauSo2;
            nhapPhanSo(out tuSo1, out mauSo1, "1");
            nhapPhanSo(out tuSo2, out mauSo2, "2");
            PhanSo ps1 = new PhanSo(tuSo1, mauSo1);
            PhanSo ps2 = new PhanSo(tuSo2, mauSo2);
            int choice;
            Console.WriteLine("1. Tinh tong hai phan so");
            Console.WriteLine("2. Tinh hieu hai phan so");
            Console.WriteLine("3. Tinh tich hai phan so");
            Console.WriteLine("4. Tinh thuong hai phan so");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("Chon chuc nang");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lua chon khong hop le. Vui long nhap so nguyen");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        PhanSo tong = ps1 + ps2;
                        Console.WriteLine("Tong cua hai phan so: " + tong.ToString());
                        break;
                    case 2:
                        PhanSo hieu = ps1 - ps2;
                        Console.WriteLine("Hieu cua hai phan so: " + hieu.ToString());
                        break;
                    case 3:
                        PhanSo tich = ps1 * ps2;
                        Console.WriteLine("Tich cua hai phan so: " + tich.ToString());
                        break;
                    case 4:
                        if(ps2.getTuSo() == 0)
                        {
                            Console.WriteLine("Khong the chia cho phan so co tu so bang 0");
                            break;
                        }
                        else
                        {
                            PhanSo thuong = ps1 / ps2;
                            Console.WriteLine("Thuong cua hai phan so: " + thuong.ToString());
                        }
                            break;
                    case 5:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nay");
                        break;
                }
            } while (choice != 5);
        }

        public void runDayPhanSo()
        {
            List<PhanSo> danhSachPhanSo = new List<PhanSo>();
            int n;
            do
            {
                Console.WriteLine("Nhap so phan tu la so nguyen duong");
            }
            while (!int.TryParse(Console.ReadLine(),out n) || n < 1);
            Console.WriteLine("Nhap day cac phan so");
            for (int i = 0; i < n; i++)
            {
                int tu, mau;
                nhapPhanSo(out tu, out mau, (i + 1).ToString());
                danhSachPhanSo.Add(new PhanSo(tu, mau));
            }
            Console.WriteLine("1. Xuat ra danh sach vua nhap");
            Console.WriteLine("2. Tim phan so lon nhat");
            Console.WriteLine("3. Sap xep danh sach phan so");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("Chon chuc nang");
            int choice;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Nhap so nguyen");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        xuatDanhSach(danhSachPhanSo);
                        break;
                    case 2:
                        timPhanSoLonNhat(danhSachPhanSo);
                        break;
                    case 3:
                        sapxepDanhSachPhanSo(danhSachPhanSo);
                        xuatDanhSach(danhSachPhanSo);
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nay");
                        break;
                }
            } while (choice != 4);
        }
    }
}
