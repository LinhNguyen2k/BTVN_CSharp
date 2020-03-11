using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());
            if(n<2 )
            {
                Console.WriteLine(n+"Day Khong Phai SNT");
            }
            else
            {
                Console.Write(n + " = ");
               for(int i=2;i<=n;i++)
                {
                   
                    while (n>0 && n%i==0)
                    {
                        Console.Write(i);
                        n = n/i;
                        if(n>1)
                        {
                            Console.Write("*");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        }
    }

