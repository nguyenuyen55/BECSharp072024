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
            Console.WriteLine("1. Đổi C sang F.");
            Console.WriteLine("2. Đổi F sang C.");
            Console.WriteLine("Vui lòng lựa chọn : ");
            int yourChoice=Convert.ToInt32(Console.ReadLine());
            if(yourChoice == 1 ) {
                Console.WriteLine("Nhập độ C : ");
                int c=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Đổi C sang F: "+c+"C= "+c*33.8+"F");
            }else if(yourChoice == 2 )
            {
                Console.WriteLine("Nhập độ F : ");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Đổi F sang C: " + f + "F= " + f *(-17.22222) + "C");
            }
        }
    }
}
