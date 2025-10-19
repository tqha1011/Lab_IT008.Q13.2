using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    public class NhaPho : BatDongSan
    {
        protected int namxaydung;
        protected int sotang;

        public override void nhap()
        {
            base.nhap();
            do
            {
                Console.WriteLine("Nhap nam xay dung(>0)");
            } while (!int.TryParse(Console.ReadLine(), out namxaydung) || namxaydung <= 0);
            do
            {
                Console.WriteLine("Nhap so tang(>0)");
            } while (!int.TryParse(Console.ReadLine(), out sotang) || sotang <= 0);
        }

        public override void xuat()
        {
            Console.WriteLine("Loai bat dong san: Nha Pho");
            base.xuat();
            Console.WriteLine("Nam xay dung: " + namxaydung);
            Console.WriteLine("So tang: " + sotang);
        }

        public override string getLoai()
        {
            return "nha pho";
        }

        public int getNam()
        {
            return namxaydung;
        }
    }
}
