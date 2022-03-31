using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class MayLanh2: MayLanh
    {
        private bool khuMui;
        private bool khangKhuan;
        public MayLanh2(): base()
        {
            this.khuMui = false;
            this.khangKhuan = false;
        }
        public MayLanh2(string maSP, string tenSP, decimal gia, string noiSX, int slBan, bool inverter, bool khuMui, bool khangKhuan) : base(maSP, tenSP, gia, noiSX, slBan, inverter)
        {
            this.khuMui = khuMui;
            this.khangKhuan = khangKhuan;
            this.gia = inverter ? (khuMui ? (khangKhuan ? 3500 : 3000) : 2500) : 2000;
        }
        public override void input()
        {
            base.input();
            Console.Write("Khử mùi: ");
            khuMui = Boolean.Parse(Console.ReadLine());
            Console.Write("Kháng khuẩn: ");
            khangKhuan = Boolean.Parse(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Khử mùi: {0}", khuMui);
            Console.WriteLine("Kháng khuẩn: {0}", khangKhuan);
        }

        public override string inChuoi()
        {
            return this.maSP + ", Máy lạnh loại 1," + this.tenSP + ", " + this.noiSX + ", " + this.gia + ", inverter: " + this.inverter + ", khử khuẩn: " + this.khangKhuan + ", " + ", khử mùi: " + this.khuMui + this.slBan;
        }
    }
}
