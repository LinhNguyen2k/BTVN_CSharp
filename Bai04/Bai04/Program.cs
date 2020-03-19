using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class Program
    {
        struct Date
        {
            public int Day;
            public int Month;
            public int Year;
        }
        struct Student
        {
            public int ID;
            public String Name;
            public Date DateOfBirth;
        }
        static void Nhap(out Student s)
        {
            Console.Write("Nhap ID: ");
            s.ID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            s.DateOfBirth.Day = int.Parse(Console.ReadLine());
            Console.Write("Thang sinh: ");
            s.DateOfBirth.Month = int.Parse(Console.ReadLine());
            Console.Write("Nam sinh: ");
            s.DateOfBirth.Year = int.Parse(Console.ReadLine());
        }
        static void XUat(Student s)
        {
            Console.WriteLine(s.ID + "\t" + s.Name + "\t" + s.DateOfBirth.Day + "/" + s.DateOfBirth.Month + "/" + s.DateOfBirth.Year);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so sv: ");
            int n = int.Parse(Console.ReadLine());
            Student[] list = new Student[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sv thu " + (i + 1));
                Nhap(out list[i]);
            }

            Console.WriteLine("Ma sv\tTen\tNgay sinh");
            for (int i = 0; i < n; i++)
            {
                XUat(list[i]);
            }
          
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (list[i].DateOfBirth.Year > list[j].DateOfBirth.Year)
                    {
                        Student temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
           
            Console.WriteLine("Danh sach sau khi sap xep theo nam sinh: ");
            Console.WriteLine("Ma sv\tTen\tNgay sinh");
            for (int i = 0; i < n; i++)
            {
                XUat(list[i]);
            }
            Console.ReadKey();
        }
    }
}
