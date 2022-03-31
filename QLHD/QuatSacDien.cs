using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class RechargeableFan: Equipment
    {
        private int pin;
        public RechargeableFan() : base()
        {
            this.pin = 0;
            this.gia = 0;
        }
        public RechargeableFan(string maSP, string tenSP, decimal gia, string noiSX, int pin, int slBan) : base(maSP, tenSP, gia, noiSX, slBan)
        {
            this.pin = pin;
            this.gia = pin * 500;
        }
        public override void input()
        {
            base.input(); 
            Console.Write("Pin: ");
            pin = Int32.Parse(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Pin: {0}", pin);
        }

        public override string inChuoi()
        {
            return this.maSP + ", Máy quạt hơi nước," + this.tenSP + ", " + this.noiSX + ", " + this.gia + ", " + this.pin + ", " + this.slBan;
        }
    }
}
