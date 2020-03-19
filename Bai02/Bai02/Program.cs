using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, x;
            int n;
            Nhap(out A, out x, out n);
            Console.WriteLine("S = " + ThucHien(A, x, n));
            Console.ReadKey();
        }
        static void Nhap(out float A, out float x, out int n)
        {
            Console.Write("Nhap so thuc A: ");
            A = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap so thuc x : ");
                x = float.Parse(Console.ReadLine());
                if (x <= 0) Console.WriteLine("Nhap lai x > 0");
            } while (x <= 0);
            do
            {
                Console.Write("Nhap so nguyen duog 5<= n <=20: ");
                n = int.Parse(Console.ReadLine());
                if (n < 5 || n > 20) Console.WriteLine("Nhap lai 5<= n <= 20");
            } while (n < 5 || n > 20);
        }
        static double LuyThua(float x, int k)
        {
            double result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= x;
            }
            return Math.Sqrt(result);
        }
        static double ThucHien(float A, float x, int n)
        {
            double S = A;
            for (int i = 0; i < n; i++)
            {
                S +=(float) Math.Pow(-1, i) * LuyThua(x, i) / (n - i + 1);
            }
            return S;
        }
    }
}
   