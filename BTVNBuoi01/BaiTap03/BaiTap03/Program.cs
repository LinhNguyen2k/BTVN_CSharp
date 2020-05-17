using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\tCac uoc cua " + a + " la:");
            for(int i=1; i<a;i++)
            {
                if (a % i == 0)
                    Console.Write(i+"\t");
            }
            Console.ReadKey();
        }
    }
}
