using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class MayLanh1: MayLanh
    {
        public MayLanh1(): base()
        {
            gia = 1000;
        }
        public MayLanh1(string maSP, string tenSP, decimal gia, string noiSX, int slBan, bool inverter) : base(maSP, tenSP, gia, noiSX, slBan, inverter)
        {
            this.gia = inverter ? 1500 : 1000;
        }
        public override void input()
        {
            base.input();
        }
        public override void output()
        {
            base.output();
        }
        public override string inChuoi()
        {
            return this.maSP + ", Máy lạnh loại 1," + this.tenSP + ", " + this.noiSX + ", " + this.gia + ", inverter: " + this.inverter + ", " + this.slBan;
        }
    }
}
