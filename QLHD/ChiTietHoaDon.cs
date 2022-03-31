using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class ChiTietHoaDon
    {
        protected Fan qd;
        protected SteamFan qhn;
        protected RechargeableFan qsd;
        protected MayLanh1 ml1;
        protected MayLanh2 ml2;
        protected int soluong;
        public ChiTietHoaDon()
        {
            this.qd = null;
            this.qhn = null;
            this.qsd = null;
            this.ml1 = null;
            this.ml2 = null;
            this.soluong = 0;
        }

        public ChiTietHoaDon(Fan qd, SteamFan qhn, RechargeableFan qsd, MayLanh1 ml1, MayLanh2 ml2, int sl)
        {
            this.qd = qd;
            this.qhn = qhn;
            this.qsd = qsd;
            this.ml1 = ml1;
            this.ml2 = ml2;
            this.soluong = sl;
        }

        public virtual void input()
        {
            Console.Write("Số lượng chi tiết trong danh sách các chi tiết hóa đơn: ");
            this.soluong = Int32.Parse(Console.ReadLine());
            for (int i=1; i<=soluong; i++)
            {
                Console.Write("Nhập chi tiết hóa đơn thứ "+i+"\n");
                int chon;
                Console.Write("Chọn loại thiết bị điện (1-máy quạt, 2- máy lạnh): ");

                chon = Int32.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    int chon1;
                    Console.Write("Chọn loại máy quạt (1-máy quạt đứng,2- máy quạt hơi nước, 3 – máy quạt sạc điện): ");
                    chon1 = Int32.Parse(Console.ReadLine());

                    if (chon1 == 1)
                    {
                        qd = new Fan();
                        qd.input();
                    }
                    if (chon1 == 2)
                    {
                        qhn = new SteamFan();
                        qhn.input();
                    }
                    if (chon1 == 3)
                    {
                        qsd = new RechargeableFan();
                        qsd.input();
                    }
                }
                if (chon == 2)
                {
                    Console.Write("Chọn loại máy lạnh (1-máy lạnh loại 1,2- máy lạnh loại 2): ");
                    if (chon == 1)
                    {
                        ml1 = new MayLanh1();
                        ml1.input();
                    }
                    if (chon == 2)
                    {
                        ml2 = new MayLanh2();
                        ml2.input();
                    }
                }
            }                
        }
        public virtual void output()
        {
            Console.Write("Số lượng chi tiết hóa đơn: ", this.soluong);
            for (int i = 1; i <= soluong; i++)
            {
                if(qd!=null)
                {
                    qd.output();
                }
                if (qhn != null)
                {
                    qhn.output();
                }
                if (qsd != null)
                {
                    qsd.output();
                }
                if (ml1 != null)
                {
                    ml1.output();
                }
                if (ml2 != null)
                {
                    ml2.output();
                }
            }
 
        }

        public virtual decimal TongGia()
        {
            decimal gia = 0;
            for (int i = 1; i <= soluong; i++)
            {
                if (qd != null)
                {
                    gia+= qd.gia*qd.slBan;
                }
                if (qhn != null)
                {
                    gia += qd.gia * qd.slBan;
                }
                if (qsd != null)
                {
                    gia += qd.gia * qd.slBan;
                }
                if (ml1 != null)
                {
                    gia += qd.gia * qd.slBan;
                }
                if (ml2 != null)
                {
                    gia += qd.gia * qd.slBan;
                }
            }
            return gia;
        }

        public string inChuoi()
        {
            string mayquat = "";
            string maylanh = "";
            for (int i = 1; i <= soluong; i++)
            {
                if (qd != null)
                {
                    mayquat += "\n" + qd.inChuoi() + "\n";
                }
                if (qhn != null)
                {
                    mayquat += "\n" + qhn.inChuoi() + "\n";
                }
                if (qsd != null)
                {
                    mayquat += "\n" + qsd.inChuoi() + "\n";
                }
                if (ml1 != null)
                {
                    maylanh += "\n" + ml1.inChuoi() + "\n";
                }
                if (ml2 != null)
                {
                    maylanh += "\n" + ml2.inChuoi() + "\n";
                }
            }
            return "\nMáy quạt: " + mayquat + "\nMáy lạnh: "+ maylanh;
        }

    }
}
