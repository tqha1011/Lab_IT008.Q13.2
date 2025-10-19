using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.In ra lich cua thang");
            Console.WriteLine("2.Xuat tat ca ten tap tin va thu muc con");
            Console.WriteLine("3.Chuong trinh ma tran co cac chuc nang");
            Console.WriteLine("4.Xay dung lop phan so");
            Console.WriteLine("5.Bai 5");
            Console.WriteLine("6. Thoat");
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
                        Bai1 bai1 = new Bai1();
                        bai1.run();
                        break;
                    case 2:
                        Bai2 bai2 = new Bai2();
                        bai2.run();
                        break;
                    case 3:
                        Bai3 bai3 = new Bai3();
                        bai3.run();
                        break;
                    case 4:
                        Bai4 bai4 = new Bai4();
                        Console.WriteLine("1. Tinh tong hieu tich thuong");
                        Console.WriteLine("2. Thao tac tren day so");
                        Console.WriteLine("3. Thuc hien ca 2");
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
                                    bai4.runPhepTinh();
                                    break;
                                case 2:
                                    bai4.runDayPhanSo();
                                    break;
                                case 3:
                                    bai4.runPhepTinh();
                                    bai4.runDayPhanSo();
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("Khong co chuc nang nay");
                                    break;

                            }
                        } while (select != 4);
                        break;
                    case 5:
                        Bai5 bai5 = new Bai5();
                        bai5.run();
                        break;
                    case 6:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Khong co lua chon nay");
                        break;
                }
            } while (choice != 6);
        }
    }
}
