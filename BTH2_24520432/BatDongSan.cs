using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    public abstract class BatDongSan
    {
        protected string diadiem;
        protected double dientich;
        protected double giaban;

        public virtual void nhap()
        {
            Console.WriteLine("Nhap dia diem");
            diadiem = Console.ReadLine();
            do
            {
                Console.WriteLine("Nhap dien tich(>0)");
            }while (!double.TryParse(Console.ReadLine(),out dientich) || dientich <= 0);

            do
            {
                Console.WriteLine("Nhap gia ban(>0)");
            } while (!double.TryParse(Console.ReadLine(),out giaban) || giaban < 0);
        }

        public virtual void xuat()
        {
            Console.WriteLine("Dia diem: " + diadiem);
            Console.WriteLine("Dien tich: " + dientich);
            Console.WriteLine("Gia ban: " + giaban);
        }

        public double getGiaban()
        {
            return giaban;
        }

        public double getDientich()
        {
            return dientich;
        }

        public string getDiadiem()
        {
            return diadiem;
        }   
        public abstract string getLoai();
    }
}
