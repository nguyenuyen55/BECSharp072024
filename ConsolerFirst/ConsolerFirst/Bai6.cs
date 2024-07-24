using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    //Bài 6: Kiểm tra một số là số chẵn hay số lẻ trong C#
    internal class Bai6
    {
        public string KiemTraSoChanHaySoLe(int inputNumber)
        {
            var result = inputNumber % 2 == 0 ? inputNumber + " Là số chẵn " : inputNumber + " Là số lẻ";
            return result;
        }
    }
}
