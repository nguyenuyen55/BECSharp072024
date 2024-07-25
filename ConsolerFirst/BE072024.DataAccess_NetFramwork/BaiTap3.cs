using BE2507.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork
{
    //Bài 1: Hãy định nghĩa kiểu dữ liệu PhanSo đại diện cho kiểu phân số.
    //    Qua đó, viết chương trình cho phép người dùng thực hiện các phép cộng,
    //    trừ, nhân, chia 2 phân số.
    static class BaiTap3
    {
        public static void congPhanSo(PhanTu phanTuFirst,PhanTu phanTuSecond)
        {
            string result = "";
            if(phanTuFirst.tu == 0 || phanTuSecond.tu == 0)
            {
                result = "tử của 1 trong 2 phân số không được bằng không";
            }
        }
    }
}
