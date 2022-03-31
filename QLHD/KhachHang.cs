using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class KhachHang
    {
        public string maKH;
        public string tenKH;
        public string sdt;
        public string diachi;
        public KhachHang()
        {
            this.maKH = "";
            this.tenKH = "";
            this.sdt = "";
            this.diachi = "";
        }

        public KhachHang(string maKH, string tenKH, string sdt, string diachi)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        public void input()
        {
            Console.Write("Nhập mã khách hàng: ");
            this.maKH = Console.ReadLine();
            Console.Write("Nhập tên khách hàng: ");
            this.tenKH = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            this.sdt = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            this.diachi = Console.ReadLine();
        }

        public void output()
        {
            Console.WriteLine("Mã khách hàng: {0}", this.maKH);
            Console.WriteLine("Tên khách hàng: {0}", this.tenKH);
            Console.WriteLine("Số điện thoại: {0}", this.sdt);
            Console.WriteLine("Địa chỉ: {0}", this.diachi);
        }

        public string inChuoi()
        {
            return "\nThông tin khác hàng: " + this.maKH + ", " + this.tenKH + ", " + this.diachi + ", " + this.sdt;
        }
    }
}
