using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNB04
{
    class Program
    {
        static Leader[] ld = new Leader[1000];
        static HocVien[] hv = new HocVien[1000];
        static int n, m;
        static void Main(string[] args)
        {
            String name;
            int money = 0;
            input(out ld, out n, out hv, out m);
            output(ld, n, hv, m);
            randomHV(hv, m);
            tangCongNo(hv, m);
            thanhToan(out name, money);
            Console.ReadKey();
        }

        static void input(out Leader[] ld, out int n, out HocVien[] hv, out int m)
        {
            Console.WriteLine("Nhap so luong leader: ");
            n = int.Parse(Console.ReadLine());
            ld = new Leader[n];
            Console.WriteLine("=====NHAP THONG TIN LEADER=====");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("======Nhap thong tin leader thu " + (i + 1) + "======");
                ld[i] = new Leader();
                ld[i].input();
            }
            Console.WriteLine("Nhap so luong hoc vien: ");
            m = int.Parse(Console.ReadLine());
            hv = new HocVien[m];
            Console.WriteLine("=====NHAP THONG TIN HOC VIEN=====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("======Nhap thong tin leader thu " + (i + 1) + "======");
                hv[i] = new HocVien();
                hv[i].input();
            }
        }
        static void output(Leader[] ld, int n, HocVien[] hv, int m)
        {
            Console.WriteLine("\t=====THONG TIN LEADER=====");
            Console.WriteLine("\tTen\t\tGioiTinh\tDiaChi\tNY?\tChucVu");
            for (int i = 0; i < n; i++)
            {
                ld[i].output();
            }
            Console.WriteLine("\t=====THONG TIN HOC VIEN=====");
            Console.WriteLine("\tTen\t\tGioiTinh\tDiaChi\tNY?\tCongNo");
            for (int i = 0; i < m; i++)
            {
                hv[i].output();
            }
        }

        static void thanhToan(out String name, int money)
        {
            int dem = 0;
            Console.WriteLine("Nhap ten hoc vien can thanh toan: ");
            name = Console.ReadLine();
            for (int i = 0; i < m; i++)
            {
                if (hv[i].Name.Equals(name))
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Nhap sai ten hoc vien roi a!!!");
            }
            else
            {
                Console.WriteLine("Nhap so tien muon thanh toan cong no: ");
                money = int.Parse(Console.ReadLine());
                for (int i = 0; i < m; i++)
                {
                    if (hv[i].Name.Equals(name))
                    {
                        hv[i].thanhToan(money);
                    }
                }
                Console.WriteLine("\t=====THONG TIN HOC VIEN SAU KHI THANH TOAN CONG NO=====");
                Console.WriteLine("\tTen\t\tGioiTinh\tDiaChi\tNY?\tCongNo");
                for (int i = 0; i < m; i++)
                {
                    hv[i].output();
                }
            }
        }
        static void randomHV(HocVien[] hv, int m)
        {
            Random rd = new Random();
            int gt = rd.Next(0, m - 1);
            for (int i = 0; i < m; i++)
            {

                if (i == gt && Equals(hv[i].IsLove, "false"))
                {
                    Console.WriteLine("\t=====THONG TIN HOC VIEN NGAU NHIEN CHUA CO NY=====");
                    Console.WriteLine("\tTen\t\tGioiTinh\tDiaChi\tNY?\tCongNo");
                    hv[i].output();
                }
            }
        }
        static void tangCongNo(HocVien[] hv, int m)
        {
            for (int i = 0; i < m; i++)
            {
                if (Equals(hv[i].IsLove, "true"))
                {
                    hv[i].Debt += 5000;
                }
            }
            Console.WriteLine("=====DANH SACH HOC VIEN SAU KHI TANG CONG NO LA=====");
            Console.WriteLine("\tTen\t\tGioiTinh\tDiaChi\tNY?\tCongNo");
            for (int i = 0; i < m; i++)
            {
                hv[i].output();
            }
        }
    }
}