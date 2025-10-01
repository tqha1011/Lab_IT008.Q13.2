using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static bool songuyento(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static bool Sochinhphuong(int n)
        {
            if(n < 0) return false;
            int sqrt = (int)Math.Sqrt(n);
            if (sqrt * sqrt == n) return true;
            else return false;
        }
        static int tongsole(int []list)
        {
            int tong = 0;
            foreach (int i in list)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }
            return tong;
        }
        static int demsonguyento(int[] list)
        {
            int dem = 0;
            foreach (int i in list)
            {
                if(songuyento(i))
                {
                    dem++;
                }
            }
            return dem;
        }
        static int sochinhphuongmin(int[] list)
        {
            int min = int.MaxValue;
            foreach (int i in list)
            {
                if(Sochinhphuong(i) && i < min)
                {
                    min = i;
                }
            }
            if (min == int.MaxValue) return -1;
            return min;
        }
        static void xuatmang(int[] list, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
        static int[] randomarray(int n , int min , int max)
        {
            var rand = new Random();
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = rand.Next(min, max + 1);
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so phan tu mang");
            int n = int.Parse(Console.ReadLine());
            int[] list = randomarray(n, -100, 100);
            int choice;
            Console.WriteLine("1. Xuat mang");
            Console.WriteLine("2. Tinh tong cac so le");
            Console.WriteLine("3. Dem so nguyen to");
            Console.WriteLine("4. Tim so chinh phuong nho nhat");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("Chon chuc nang : ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    xuatmang(list, n); 
                    break;
                case 2:
                    Console.WriteLine(tongsole(list));
                    break;
                case 3:
                    Console.WriteLine(demsonguyento(list));
                    break;
                case 4:
                    Console.WriteLine(sochinhphuongmin(list));
                    break;
                default:
                    Console.WriteLine("Thoat");
                    break;
            }
        }
    }
}
