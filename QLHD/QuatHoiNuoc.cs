using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class SteamFan: Equipment
    {
        private int dungtich;
        public SteamFan(): base()
        {
            this.dungtich = 0;
            this.gia = 0;
        }
        public SteamFan(string maSP, string tenSP, decimal gia, string noiSX, int dungtich, int slBan) : base(maSP, tenSP, gia, noiSX, slBan)
        {
            this.dungtich = dungtich;
            this.gia = dungtich * 400;
        }
        public override void input()
        {
            base.input();
            Console.Write("Dung tich: ");
            dungtich = Int32.Parse(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Dung tich: {0}", dungtich);
        }
        public override string inChuoi()
        {
            return this.maSP + ", Máy quạt hơi nước," + this.tenSP + ", " + this.noiSX + ", " + this.gia + ", " +this.dungtich + ", "+ this.slBan;
        }
    }
}
