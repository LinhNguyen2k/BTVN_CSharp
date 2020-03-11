using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Nhap canh a:");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh b:");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh c:");
            c = float.Parse(Console.ReadLine());
            if((a+b)<= c && (b+c)<=a && (c+a)<=b)
            {
                Console.Write("\tDay khong phai tam giac");
            }
            else
            {

                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("tam giac deu");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine("Tam giac vuong");
                    }
                }
                else Console.WriteLine("Tam giac thuong");
            }
            Console.ReadKey();
        }
    }
}
