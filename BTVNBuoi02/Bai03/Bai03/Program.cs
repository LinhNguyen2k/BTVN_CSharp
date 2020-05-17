using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mhap chuoi s Ho,ten dem, ten, nam sinh: ");
            String s = Console.ReadLine();
            Nhap(s);
            Show();
            Console.WriteLine("Tuoi: " + Age());
            Console.ReadKey();
           
        }
        static String[] a;
        static void Nhap(String s)
        {
            a = s.Split(' ');
            Console.Write("str[]={");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine("}");
        }
        static void Show()
        {
            Console.WriteLine("Ho: " + a[0]);
            Console.WriteLine("Ten Dem: " + a[1]);
            Console.WriteLine("Ten: " + a[2]);
            Console.WriteLine("nam Sinh: " + a[3]);
        }
        static int Age()
        {
            return 2020 - int.Parse(a[a.Length - 1]);
        }
    }

}
 