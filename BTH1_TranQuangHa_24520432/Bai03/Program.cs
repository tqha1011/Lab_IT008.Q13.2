using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static bool leapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        static bool checkDate(int day,int month , int year)
        {
            if (month < 1 || month > 12 || year <= 0) return false;
            int maxday;
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    maxday = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    maxday = 30;
                    break;
                case 2:
                    if(leapYear(year))
                        maxday = 29;
                    else
                        maxday = 28;
                    break;
                default:
                    return false;
            }
            return day >= 1 && day <= maxday;
        }
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());  
            int year = int.Parse(Console.ReadLine());   
            if (checkDate(day, month, year))
                Console.WriteLine("Hop le");
            else
                Console.WriteLine("Khong hop le");
        }
    }
}
