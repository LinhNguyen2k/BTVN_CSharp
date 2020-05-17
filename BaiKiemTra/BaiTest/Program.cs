using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    class Program
    {
        public static void TimKiem()
        {
            String name;
            Console.WriteLine("Nhap ten can tim kiem:");
            int dem = 0;
            name = (Console.ReadLine());
            foreach (NhanVien x in list)
            {
                if(x.HoTen.Contains(name))
                {
                    dem++;
                    Console.WriteLine(x.ToString());
                }
            }
            if(dem==0)
            {
                Console.WriteLine("\n------Khong co-------");
            }
         

        }
        public static void Sort()
        {
          
            for(int i=0;i<n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (list[i].TinhLuong() > list[j].TinhLuong()) ;
                    {
                        NhanVien temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            Xuat();
        }
        public static void Xuat()
        {
            foreach (NhanVien x in list)
            {
                Console.WriteLine(x);
            }
        }
        public static int n;
        public static List<NhanVien> list = new List<NhanVien>();
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Nhap so nhan vien:");
            n = int.Parse(Console.ReadLine());

            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap nhan vien thu :"+(i+1));
                NhanVien a = new NhanVien();
                a.nhap();
                list.Add(a);

            }
            Console.WriteLine("\n\t\t-------Danh Sach Ban Vua Nhap-------");
            foreach (NhanVien x in list)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n\t\t-------Danh sach theo ten ban vua tim-------");
            TimKiem();
            Console.WriteLine("\n\t\t-------Mang Sau Khi Sort-------");
            Sort();
            Console.ReadKey();
        }
        
    }
}
