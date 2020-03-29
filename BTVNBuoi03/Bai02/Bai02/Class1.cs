using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Class1
    {
        static void Main(string[] args)
        {

            Program x = new Program(2, 3, 2);
            Program y = new Program(2, 2, 2);
            Program xsub = new Program();
            Program ysub = new Program();
            xsub = -x;
            ysub = -y;
            xsub.xuat();
            ysub.xuat();
            Program sum = new Program();
            sum = xsub + ysub;
            sum.xuat();
            Console.ReadKey();

        }

    }
}
