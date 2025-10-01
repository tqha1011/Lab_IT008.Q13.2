using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Program
    {
        static bool snt(int n)
        {
            if(n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void nhapMang(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static void xuatMang(int[,] a, int n, int m)
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
        static int timMax(int[,] a , int n, int m)
        {
            int max = a[0, 0];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if(a[i,j] > max)
                        max = a[i, j];
                }
            }
            return max;
        }
        static int timMin(int[,] a, int n, int m)
        {
            int min = a[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                        min = a[i, j];
                }
            }
            return min;
        }
        static int dongcoTongLonNhat(int[,] a, int n,int m)
        {
            int max = 0;
            int pos = -1;
            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                for(int j=0;j < m; j++)
                {
                    sum += a[i, j];
                }
                if(sum > max)
                {
                    max = sum;
                    pos = i;
                }
            }
            return pos;
        }
        static int tongsoKhongPhaiNguyenTo(int[,] a, int n, int m)
        {
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(!snt(a[i,j]))
                        sum += a[i, j];
                }
            }
            return sum;
        }
        static void deleterow(int[,]a ,ref int n,ref int m,int row)
        {
            if(row >= 0 && row < n)
            {
                for(int i = row; i < n - 1; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        a[i, j] = a[i + 1, j];
                    }
                }
                n--;
            }
        }
        static int cotchuaMax(int[,] a, int n, int m)
        {
            int max = timMax(a, n, m);
            for(int j = 0; j < m; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    if(a[i,j] == max)
                        return j;
                }
            }
            return -1;
        }
        static void deleteColumn(int[,]a ,ref int n, ref int m)
        {
            int col = cotchuaMax(a, n, m);
            if(col != -1)
            {
                for(int j = col; j < m - 1; j++)
                {
                    for(int i = 0; i < n; i++)
                    {
                        a[i, j] = a[i, j + 1];
                    }
                }
                m--;
            }
        }
        static int[,] randomarray(int n,int m,int min,int max)
        {
            var md = new Random();
            int[,] a = new int[n, m];
            for(int i = 0; i < n; i++)
                for(int j = 0; j < m; j++)
                    a[i, j] = md.Next(min, max);
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so cot va so hang cua ma tran");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int [,] a = randomarray(n, m, -100, 100);
            Console.WriteLine("1. Xuat ma tran: ");
            Console.WriteLine("2. Tim phan tu lon nhat/nho nhat");
            Console.WriteLine("3. Tim dong co tong lon nhat");
            Console.WriteLine("4. Tong cac so khong phai la so nguyen to");
            Console.WriteLine("5. Xoa dong thu k trong ma tran");
            Console.WriteLine("6. Xoa cot chua phan tu lon nhat");
            Console.Write("Chon chuc nang: ");
            int choice;
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    xuatMang(a, n, m);
                    break;
                case 2:
                    Console.WriteLine("Max :" + timMax(a,n,m));
                    Console.WriteLine("Min :" + timMin(a,n,m));
                    break;
                case 3:
                    Console.WriteLine(dongcoTongLonNhat(a,n,m));
                    break;
                case 4:
                    Console.WriteLine(tongsoKhongPhaiNguyenTo(a,n,m));
                    break;
                case 5:
                    Console.Write("Nhap dong can xoa: ");
                    int row = int.Parse(Console.ReadLine());
                    deleterow(a, ref n, ref m, row);
                    xuatMang(a, n, m);
                    break;
                case 6:
                    deleteColumn(a,ref n,ref m);
                    xuatMang(a, n, m);
                    break;
                default:
                    Console.WriteLine("Chuc nang khong hop le");
                    break;
            }
        }
    }
}
