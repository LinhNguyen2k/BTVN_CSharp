using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap c:");
            float c = float.Parse(Console.ReadLine());
            float mu = 1, e = 1;
            int gt = 1, i = 1;
            while (mu / gt > 0.00001)
            {
                e = e + mu / gt;
                i++;
                mu = mu * a;
                gt = gt * i;
            }
            Console.WriteLine("e mu" + a + "=" + e);
            Console.ReadKey();
        }
    }
}
