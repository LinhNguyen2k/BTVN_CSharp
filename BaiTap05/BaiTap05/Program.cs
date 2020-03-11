using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k=0;
            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());
            if(n < 2)
            {
                Console.WriteLine("Khong Phai SNT");
            }
            else
            {
                for(int i=2;i<n;i++)
                {
                    if(n%i==0)
                    {
                        k++;
                        break;
                    }
                }
                if(k>0)
                {
                    Console.WriteLine( n+ " Khong Phai SNT");
                }
                else
                {
                    Console.WriteLine( n+ " La SNT");
                }
            }
            Console.ReadKey();
        }
    }
}
