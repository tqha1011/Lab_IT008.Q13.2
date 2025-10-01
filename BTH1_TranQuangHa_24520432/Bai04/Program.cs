using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static bool namnhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0)) return true;
            return false;
        }
        static int songaycuathang(int thang, int nam)
        {
            if(thang <= 0 || thang > 12 || nam < 0)
            {
                return -1;
            }
            int maxday;
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    maxday = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    maxday = 30;
                    break;
                case 2:
                    if(namnhuan(nam)) maxday = 29;
                    else maxday = 28;
                    break;
                default:
                    return -1;
            }
            return maxday;
        }
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int res = songaycuathang(month, year);
            if (res == -1)
            {
                Console.WriteLine("Khong hop le");
            }
            else
            {
                Console.WriteLine("So ngay cua thang do la :");
                Console.WriteLine(res);
            }
        }
    }
}
