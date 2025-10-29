using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520432
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(tuSo), Math.Abs(mauSo));
            tuSo /= ucln;
            mauSo /= ucln;
            if (mauSo < 0)
            {
                tuSo = -tuSo;
                mauSo = -mauSo;
            }
        }
        public override string ToString()
        {
            return $"{tuSo}/{mauSo}";
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuSo * b.mauSo + b.tuSo * a.mauSo;
            int mauSoMoi = a.mauSo * b.mauSo;
            PhanSo ketQua = new PhanSo(tuSoMoi, mauSoMoi);
            ketQua.RutGon();
            return ketQua;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuSo * b.mauSo - b.tuSo * a.mauSo;
            int mauSoMoi = a.mauSo * b.mauSo;
            PhanSo ketQua = new PhanSo(tuSoMoi, mauSoMoi);
            ketQua.RutGon();
            return ketQua;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int newTu = a.tuSo * b.tuSo;
            int newMau = a.mauSo * b.mauSo;
            PhanSo ketQua = new PhanSo(newTu, newMau);
            ketQua.RutGon();
            return ketQua;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            int newTu = a.tuSo * b.mauSo;
            int newMau = a.mauSo * b.tuSo;
            PhanSo ketQua = new PhanSo(newTu, newMau);
            ketQua.RutGon();
            return ketQua;
        }

        public static bool operator >(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo > a.mauSo * b.tuSo;
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo < a.mauSo * b.tuSo;
        }

        public int getTuSo()
        {
            return tuSo;
        }
    }
}
