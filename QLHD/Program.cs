using System;
using System.Text;

namespace QLHD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sl;
            Console.Write("Số lượng hóa đơn muốn nhập: ");
            sl = Int32.Parse(Console.ReadLine());
            HoaDon hd = new HoaDon();
            for (int i = 0; i < sl; i++)
            {
                hd.input();
            }
            for (int i = 0; i < sl; i++)
            {
                hd.output();
                hd.saveFile();
                Console.ReadLine();
            }
        }
    }
}
