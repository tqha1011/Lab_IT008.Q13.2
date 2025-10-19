using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    internal class Bai3
    {
        bool snt(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        void nhapMaTran(int[,] a , int n , int m)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    int value;
                    while(int.TryParse(Console.ReadLine(), out value) == false)
                    {
                        Console.WriteLine("Nhap phan tu la so nguyen");
                    }
                    a[i, j] = value;
                }
            }
        }

        void xuatMaTran(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        bool timKiemPhanTu(int[,]a,int n, int m , int x)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (a[i,j] == x) return true;
                }
            }
            return false;
        }

        void xuatSnt(int[,]a , int n , int m)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (snt(a[i,j])) Console.Write(a[i,j] + " ");
                }
            }
        }
        
        int dongCoNhieuSntNhat(int[,]a , int n , int m)
        {
            int max = 0;
            int dong = -1;
            for(int i = 0; i < n; i++)
            {
                int count = 0;
                for(int j = 0; j < m; j++)
                {
                    if (snt(a[i,j])) count++;
                }
                if (count > max)
                {
                    max = count;
                    dong = i;
                }
            }
            return dong;
        }
        
        public void run()
        {
            int n, m;
            do
            {
                Console.WriteLine("Nhap dong la so duong");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            do
            {
                Console.WriteLine("Nhap cot la so duong");
            } while (!int.TryParse(Console.ReadLine(), out m) || m < 1);

            int[,] a = new int[n, m];
            Console.WriteLine("Nhap ma tran");
            nhapMaTran(a, n, m);
            Console.WriteLine("Chon chuc nang");
            Console.WriteLine("1. Xuat ma tran");
            Console.WriteLine("2. Tim kiem mot phan tu");
            Console.WriteLine("3. Xuat cac phan tu la so nguyen to");
            Console.WriteLine("4. Tim dong co nhieu so nguyen to nhat");
            Console.WriteLine("5. Thoat");
            int choice;
            do
            {
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Nhap so nguyen tu 1-5");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ma tran");
                        xuatMaTran(a, n, m);
                        break;
                    case 2:
                        int x;
                        do
                        {
                            Console.WriteLine("Nhap so muon tim la so nguyen: ");
                        } while (!int.TryParse(Console.ReadLine(), out x));
                        if (timKiemPhanTu(a, n, m, x))
                            Console.WriteLine("Tim thay phan tu");
                        else
                            Console.WriteLine("Khong tim thay phan tu");
                        break;
                    case 3:
                        Console.WriteLine("Cac so nguyen to trong ma tran: ");
                        xuatSnt(a, n, m);
                        break;
                    case 4:
                        int dong = dongCoNhieuSntNhat(a, n, m);
                        if (dong == -1) Console.WriteLine("Khong co dong nao co so nguyen to");
                        else Console.WriteLine("Dong co nhieu so nguyen to nhat la: " + dong);
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
    }
}
    