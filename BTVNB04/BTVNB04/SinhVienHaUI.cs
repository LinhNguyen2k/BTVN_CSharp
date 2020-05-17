using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNB04
{
    class SinhVienHaUI
    {
        private String name;
        private String gender;
        private String address;
        private String isLove;

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string IsLove { get => isLove; set => isLove = value; }

        public virtual void input()
        {
            Console.WriteLine("Nhap ten: "); ;
            this.Name = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            this.Gender = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            this.Address = Console.ReadLine();
            Console.WriteLine("Da co nguoi yeu chua?(true/false): ");
            this.IsLove = Console.ReadLine();
        }
        public virtual void output()
        {
            Console.Write("\t"+this.name + "\t\t" + this.gender + "\t\t" + this.address + "\t" + this.isLove);
        }
    }
}
