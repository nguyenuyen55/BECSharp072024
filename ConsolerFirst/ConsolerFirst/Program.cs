using BE072024.DataAccess_NetFramwork;
using BE2507.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////bai 1
            Console.OutputEncoding = Encoding.UTF8;
            //bai 1
            //BaiTap1.ChuongTrinhBaiTap1();
            //BaiTap2.ChuongTrinhBaiTap2();
            //BaiTap3.ChuongTrinhBaiTap3();
BaiTap4 baiTap4 = new BaiTap4();
            baiTap4.nhapDSNhanVien();

            Console.ReadKey();
        }
    }
}
