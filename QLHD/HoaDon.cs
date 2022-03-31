using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class HoaDon
    {
        protected string maHD;
        protected DateTime ngayThanhLap;
        protected KhachHang kh;
        protected int soluong;
        protected ChiTietHoaDon cthdon;
        public HoaDon()
        {
            this.maHD = "";
            this.ngayThanhLap = DateTime.Now;
            this.kh = new KhachHang();
            this.cthdon = new ChiTietHoaDon();
        }

        public virtual void input()
        {
            Console.Write("Nhập mã hóa đơn: ");
            this.maHD = Console.ReadLine();
            Console.Write("Nhập ngày nhập hóa đơn: ");
            this.ngayThanhLap = DateTime.Parse(Console.ReadLine());
            Console.Write("Thông tin khách hàng: \n");
            this.kh = new KhachHang();
            kh.input();
            Console.WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            this.cthdon = new ChiTietHoaDon();
            cthdon.input();
        }
        public virtual void output()
        {
            Console.WriteLine("Mã hóa đơn: {0}", this.maHD);
            //this.maHD = Console.ReadLine();
            Console.WriteLine("Ngày nhập hóa đơn: {0}", this.ngayThanhLap);
            //this.ngayThanhLap = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Thông tin khách hàng:: ");
            kh.output();
            Console.WriteLine("Thông tin chi tiết hóa đơn : ");
            cthdon.output();
        }

        public string inChuoi()
        {
            return "Hóa đơn: " + this.maHD + ", " + this.ngayThanhLap + ", " + cthdon.TongGia();
        }

        public virtual void saveFile()
        {
            var filename = "danh_sach_hoa_don.txt";
            string contentfile = inChuoi() + cthdon.inChuoi(); 

            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fullpath = Path.Combine(directory_mydoc, filename);

            if (File.Exists(fullpath))
            {
                // File đã tồn tại - nối thêm nội dung
                File.AppendAllText(fullpath, contentfile);
            }
            else
            {
                // tạo mới vì chưa tồn tại file
                File.WriteAllText(fullpath, contentfile);
            }
        }
    }
}
