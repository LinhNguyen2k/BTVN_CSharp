using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Nhap d:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Nhap e:");
            int e = int.Parse(Console.ReadLine());
            int max1 = a;
            if (b > max1) max1 = b;
            if (c > max1) max1 = c;
            if (d > max1) max1 = d;
            if (e > max1) max1 = e;
            int max2 = a;
            if (b > max2 && b < max1) max2 = b;
            if (c > max2 && c < max1) max2 = c;
            if (d > max2 && d < max1) max2 = d;
            if (e > max2 && e < max1) max2 = e;
            Console.WriteLine("");
            Console.Write("MAX 2 =" + max2);
            Console.ReadKey();
        }
    }
}
