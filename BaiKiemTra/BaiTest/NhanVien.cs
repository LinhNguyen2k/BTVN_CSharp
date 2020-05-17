using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    class NhanVien
    {
        private int manv;
        private String hoTen;
        private float hesoLuong;
        private int soNgayCong;
        private float troCap;

        public int Manv { get => manv; set => manv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public float HesoLuong { get => hesoLuong; set => hesoLuong = value; }
        public int SoNgayCong { get => soNgayCong; set => soNgayCong = value; }
        public float TroCap { get => troCap; set => troCap = value; }

        public override string ToString()
        {
            return ("\tManv:" + manv + ",\tHoTen:" + HoTen + ",\tHeSoLuong:" + hesoLuong + ",\tSoNgayCong:" + soNgayCong + ",\tTroCap:" + troCap + ",\tTinhLuog:" + TinhLuong());
        }
        public float TinhLuong()
        {
            float TinhLuong = hesoLuong * 150000 * soNgayCong;
            if (soNgayCong >= 26)
            {
                TinhLuong += troCap;
            }
            else
            {
                TinhLuong -=((26-SoNgayCong)*hesoLuong*150000+(26-SoNgayCong)*hesoLuong*10000); 
            }
            return TinhLuong;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap thong tin nhan vien\n");
            Console.WriteLine("Nhap ma nhan vien:");
            manv = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten:");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap he so luong:");
            hesoLuong = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so ngay cong:");
            soNgayCong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tro cap:");
            troCap = float.Parse(Console.ReadLine());
        }

    }
}
