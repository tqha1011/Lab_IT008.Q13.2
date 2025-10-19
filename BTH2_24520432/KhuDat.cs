using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    public class KhuDat : BatDongSan
    {
        public override void nhap()
        {
            base.nhap();
        }

        public override void xuat()
        {
            Console.WriteLine("Loai bat dong san: Khu dat");
            base.xuat();
        }
        public override string getLoai()
        {
            return "Khu dat";
        }
    }
}
