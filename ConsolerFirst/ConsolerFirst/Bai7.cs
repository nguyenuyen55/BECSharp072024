using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    internal class Bai7
    {
        public string checkNumberNguyenTo(int inputNumber)
        {
            Bai5 bai5 = new Bai5();
            var result = bai5.checkSoNguyento(inputNumber) ? inputNumber + " là số nguyên tố" : inputNumber + " không phải là số nguyên tố";
            return result;
        }
    }
}