using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    public class ChungCu : BatDongSan
    {
        protected int tang;
        public override void nhap()
        {
            base.nhap();
            do
            {
                Console.WriteLine("Nhap tang la so nguyen(>0)");
            }while(!int.TryParse(Console.ReadLine(), out tang) || tang <= 0);
        }

        public override void xuat()
        {
            Console.WriteLine("Loai bat dong san: Chung cu");
            base.xuat();
            Console.WriteLine("Tang: " + tang);
        }

        public override string getLoai()
        {
            return "chung cu";
        }
    }
}
