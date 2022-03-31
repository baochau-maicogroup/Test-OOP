using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class MayLanh: Equipment
    {
        public bool inverter;
        public MayLanh(): base()
        {
            this.inverter = false;
        }
        public MayLanh(string maSP, string tenSP, decimal gia, string noiSX, int slBan, bool inverter) : base(maSP, tenSP, gia, noiSX, slBan)
        {
            this.inverter = inverter;
        }
        public override void input()
        {
            base.input();
            Console.Write("Inverter: ");
            inverter = Boolean.Parse(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Inverter: {0}", inverter);
        }

        public override string inChuoi()
        {
            return "";
        }
    }
}
