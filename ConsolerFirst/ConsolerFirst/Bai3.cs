using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    internal class Bai3
    {
        public void ChuyenDoiCVaF()
        {
            Bai1  bai1 = new Bai1();
            Console.WriteLine("1. Đổi C sang F.");
            Console.WriteLine("2. Đổi F sang C.");
            Console.WriteLine("Vui lòng lựa chọn : ");
            int yourChoice=bai1.enterNumber();
            if(yourChoice == 1 ) {
                Console.WriteLine("Nhập độ C : ");
                int inputNumberC=bai1.enterNumber();
                Console.WriteLine(" Đổi C sang F: "+inputNumberC+"C= "+inputNumberC*33.8+"F");
            }else if(yourChoice == 2 )
            {
                Console.WriteLine("Nhập độ F : ");
                int inputNumberF = bai1.enterNumber();
                Console.WriteLine(" Đổi F sang C: " + inputNumberF + "F= " + inputNumberF *(-17.22222) + "C");
            }
        }
    }
}
