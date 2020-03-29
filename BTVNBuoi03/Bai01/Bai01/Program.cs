using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So Luong: ");
            int n = int.Parse(Console.ReadLine());
            Class1[] list = new Class1[n];
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Nhap Thong Tin Hang Thu: " + (i + 1));
                list[i] = new Class1();
                list[i].NHAP();
            }
            list[0].SAPXEP(list, n);
            foreach (Class1 x in list)
            {
                x.XUAT();
            }
            Console.ReadKey();
        }
    }
}
