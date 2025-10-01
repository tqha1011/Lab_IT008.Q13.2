using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static bool snt(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static int tongsonguyento(int n)
        {
            int sum = 0;
            for(int i = 0;i < n; i++)
            {
                if(snt(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
      
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua so nguyen to be hon n : ");
            Console.WriteLine(tongsonguyento(n));
        }
    }
}
