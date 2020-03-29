using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {


        private float a, b, c;

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }

        public Program()
        {

        }
        public Program(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void xuat()
        {
            Console.WriteLine(this.a + "x^2 + " + this.b + "x + " + this.c);
        }
        public static Program operator -(Program x)
        {
            x.A *= -1;
            x.B *= -1;
            x.C *= -1;
            return x;
        }
        public static Program operator +(Program x, Program y)
        {
            Program sum = new Program();
            sum.A = x.A + y.A;
            sum.B = x.B + y.B;
            sum.C = x.C + y.C;
            return sum;
        }
        public static Program operator -(Program x, Program y)
        {
            Program subtract = new Program();
            subtract.A = x.A - y.A;
            subtract.B = x.B - y.B;
            subtract.C = x.C - y.C;
            return subtract;
        }
    }
}
