using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Ngay
    {


        private int day, month, year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public void nhap()
        {
            Console.Write("Nhap ngay: ");
            this.day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            this.month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            this.year = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write(this.day + "/" + this.month + "/" + this.year);
        }

    }
}
