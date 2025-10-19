using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    internal class Bai1
    {
        void printCalendar(int month, int year)
        {
            Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDay = (int)firstDay.DayOfWeek;
            for (int i = 0; i < startDay; i++)
            {
                Console.Write("\t");
            }
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write(day + "\t");
                if ((day + startDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public void run()
        {
            int month, year;
            do
            {
                Console.WriteLine("Nhap thang tu 1-12: ");
            }while(!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12);

            do
            {
                Console.WriteLine("Nhap nam: ");
            } while (!int.TryParse(Console.ReadLine(), out year) || year < 1);
            printCalendar(month, year);
        }
    }
}
