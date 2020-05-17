using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNB04
{
    class HocVien : SinhVienHaUI
    {

        private int debt;
        public HocVien()
        {
            this.Debt = 10000;
        }

        public int Debt { get => debt; set => debt = value; }

        public override void input()
        {
            base.input();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("\t" + this.debt);
        }
        public void thanhToan(int money)
        {
            if (money <= this.debt)
            {
                debt -= money;
            }
        }
    }
}
