using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap ngay thang nam: ");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Do la ngay :");
            DateTime date = new DateTime(year, month, day);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
