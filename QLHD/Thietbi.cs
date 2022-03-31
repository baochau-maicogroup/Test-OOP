using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class Equipment
    {
        public string maSP;
        public string tenSP;
        public decimal gia;
        public string noiSX;
        public int slBan;
        public Equipment()
        {
            this.maSP = "";
            this.tenSP = "";
            this.gia = 0;
            this.noiSX = "";
            this.slBan = 0;
        }

        public Equipment(string maSP, string tenSP, decimal gia, string noiSX, int slBan)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.gia = gia;
            this.noiSX = noiSX;
            this.slBan = slBan;
        }

        public virtual void input()
        {
            Console.Write("Nhập mã sản phẩm: ");
            this.maSP = Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            this.tenSP = Console.ReadLine();
            Console.Write("Nhập nơi sản xuất: ");
            this.noiSX = Console.ReadLine();
            Console.Write("Nhập số lượng bán: ");
            this.slBan = Int32.Parse(Console.ReadLine());
        }

        public virtual void output()
        {
            Console.WriteLine("Mã sản phẩm: {0}", this.maSP);
            Console.WriteLine("Tên sản phẩm: {0}", this.tenSP);
            Console.WriteLine("Giá bán: {0}", this.gia);
            Console.WriteLine("Nơi sản xuất: {0}", this.noiSX);
            Console.WriteLine("Số lượng bán: {0}", this.slBan);
        }

        public virtual string inChuoi()
        {
            return "";
        }
    }
}
