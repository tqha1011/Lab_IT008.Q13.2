using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    internal class Bai5
    {
        void nhapDanhSach(List<BatDongSan> danhSach)
        {
            Console.WriteLine("1. Nhap thong tin dat");
            Console.WriteLine("2. Nhap thong tin chung cu");
            Console.WriteLine("3. Nhap thong tin nha pho");
            Console.WriteLine("4. Thoat");
            int select;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out select))
                {
                    Console.WriteLine("Nhap so nguyen");
                    continue;
                }
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Thong tin nha dat: ");
                        KhuDat dat = new KhuDat();
                        dat.nhap();
                        danhSach.Add(dat);
                        break;
                    case 2:
                        Console.WriteLine("Thong tin chung cu: ");
                        ChungCu cc = new ChungCu();
                        cc.nhap();
                        danhSach.Add(cc);
                        break;
                    case 3:
                        Console.WriteLine("Thong tin nha pho: ");
                        NhaPho np = new NhaPho();
                        np.nhap();
                        danhSach.Add(np);
                        break;
                    case 4:
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Khong co lua chon nay");
                        break;
                }
            } while (select != 4);
        }
        void tongGiaBan(List<BatDongSan> danhSach)
        {
            double tongDat = 0;
            double tongNhaPho = 0;
            double tongChungCu = 0;
            foreach (var bds in danhSach)
            {
                if(bds is KhuDat dt)
                {
                    tongDat += dt.getGiaban();
                }
                else if(bds is NhaPho np)
                {
                    tongNhaPho += np.getGiaban();
                }
                else if(bds is ChungCu cc)
                {
                    tongChungCu += cc.getGiaban();
                }
            }
            Console.WriteLine("Tong gia ban dat:" + tongDat);
            Console.WriteLine("Tong gia ban nha:" + tongNhaPho);
            Console.WriteLine("Tong gia ban chung cu:"+ tongChungCu);
        }

        void xuatDanhSachNhaPho(List<BatDongSan> danhSach)
        {
            foreach (var bds in danhSach)
            {
                if(bds is NhaPho np)
                {
                    np.xuat();
                }
            }
        }

        void xuatDanhSachChungCu(List<BatDongSan> danhSach)
        {
            foreach (var bds in danhSach)
            {
                if(bds is ChungCu cc)
                {
                    cc.xuat();
                }
            }
        }

        void xuatDanhSachDat(List<BatDongSan> danhSach)
        {
            foreach (var bds in danhSach)
            {
                if(bds is KhuDat dt)
                {
                    dt.xuat();
                }
            }
        }

        void xuatDanhSachDatTren100(List<BatDongSan> danhSach)
        {
            foreach (var bds in danhSach)
            {
                if(bds is KhuDat dt)
                {
                    if(dt.getDientich() > 100)
                    {
                        dt.xuat();
                    }
                }
            }
        }

        void xuatDanhSachNhaPhoTheoYeuCau(List<BatDongSan> danhSach)
        {
            foreach (var bds in danhSach)
            {
                if(bds is NhaPho np)
                {
                    if(np.getDientich() > 60 && np.getNam() >= 2019)
                    {
                        np.xuat();
                    }
                }
            }
        }

        void timKiemTheoYeuCau(List<BatDongSan> danhSach,string diadiem,double gia,double dientich)
        {
            string addr = diadiem.ToLower();
            bool found = false;
            foreach (var bds in danhSach)
            {
                if(bds.getDiadiem().ToLower().Contains(addr) && bds.getGiaban() <= gia && bds.getDientich() >= dientich)
                {
                    if(bds is NhaPho np)
                    {
                        np.xuat();
                        found = true;
                    }
                    else if(bds is ChungCu cc)
                    {
                        cc.xuat();
                        found = true;
                    }
                }
            }
            if(!found)
            {
                Console.WriteLine("Khong tim thay bat dong san phu hop");
            }
        }
        public void run()
        {
            List<BatDongSan> danhSach = new List<BatDongSan>();
            nhapDanhSach(danhSach);
            Console.WriteLine("1. Xuat danh sach thong tin bds");
            Console.WriteLine("2. Xuat tong gia ban cua ba loai bds");
            Console.WriteLine("3. Cac khu dat > 100m2");
            Console.WriteLine("4. Nha pho > 60m2 va nam >= 2019");
            Console.WriteLine("5. Tim kiem bds");
            Console.WriteLine("6. Thoat");
            Console.WriteLine("Chon chuc nang");
            int choice;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Nhap so nguyen duong");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Danh sach khu dat:");
                        xuatDanhSachDat(danhSach);
                        Console.WriteLine("Danh sach chung cu:");
                        xuatDanhSachChungCu(danhSach);
                        Console.WriteLine("Danh sach nha pho");
                        xuatDanhSachNhaPho(danhSach);
                        break;
                    case 2:
                        tongGiaBan(danhSach);
                        break;
                    case 3:
                        Console.WriteLine("Cac khu dat > 100m2");
                        xuatDanhSachDatTren100(danhSach);
                        break;
                    case 4:
                        Console.WriteLine("Cac nha pho > 60m2 va nam >= 2019");
                        xuatDanhSachNhaPhoTheoYeuCau(danhSach);
                        break;
                    case 5:
                        string addr;
                        double price;
                        double square;
                        Console.WriteLine("Nhap dia chi");
                        addr = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Nhap gia la so duong");
                        } while (!double.TryParse(Console.ReadLine(), out price) || price < 0);

                        do
                        {
                            Console.WriteLine("Nhap dien tich la so duong");
                        } while (!double.TryParse(Console.ReadLine(), out square) || square <= 0);
                        timKiemTheoYeuCau(danhSach,addr,price,square);
                        break;
                    case 6:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Khong co chuc nang nay");
                        break;
                }
            } while (choice != 6);
        }
    }
}
