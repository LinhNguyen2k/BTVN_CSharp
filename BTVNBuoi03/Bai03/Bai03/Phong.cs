using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Phong
    {


        private String codeRoom;
        private String nameRoom;
        private String leader;
        nhanVien x;

        public string CodeRoom { get => codeRoom; set => codeRoom = value; }
        public string NameRoom { get => nameRoom; set => nameRoom = value; }
        public string Leader { get => leader; set => leader = value; }
        internal nhanVien X { get => x; set => x = value; }
        public void nhap()
        {
            Console.WriteLine("Nhap ma phong: ");
            this.codeRoom = Console.ReadLine();
            Console.WriteLine("Nhap ten phong: ");
            this.nameRoom = Console.ReadLine();
            Console.WriteLine("Nhap ten truong phong: ");
            this.Leader = Console.ReadLine();
            x = new nhanVien();
            x.nhap();
        }
        public void xuat()
        {
            x.xuat();
            Console.WriteLine("Ma phong: " + this.codeRoom + ", Ten phong kiem ke: " + this.nameRoom + " ,Truong phong:  " + this.Leader);

        }
    }
}
