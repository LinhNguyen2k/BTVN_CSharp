using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float S1=0, S2=1, S3=0;
            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                S1 += i;
                S2 *= i;
                S3 += (i - 1) * i;
            }
            Console.WriteLine("S1= " + S1 + "\t S2= " + S2 + "\tS3= " + S3);
            Console.ReadKey();
        }
    }
}
