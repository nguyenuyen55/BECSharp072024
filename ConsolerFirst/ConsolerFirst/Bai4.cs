using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    //Bài 4: Tính giai thừa của 1 số
    internal class Bai4
    {
        public int TinhGiaiThuaCuaMotSo(int inputNumber )
        {
            int multiplication = 1;
            for (int i = 1; i <= inputNumber; i++)
            {
                multiplication *= i;
            }
            return multiplication;
        }
    }
}
