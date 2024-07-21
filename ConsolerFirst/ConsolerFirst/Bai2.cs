using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    internal class Bai2
    {
        public void phuongTrinh()
        {
            Console.WriteLine("Bạn muốn giải phương trình nào ?");
            Console.WriteLine("1. Phương trình bậc 1: ax+b=0.");
            Console.WriteLine("2. Phương trình bậc 2 ax^2+bx+c=0.");
            Console.Write("Nhập lựa chọn của bạn : ");
            Bai1 bai1 = new Bai1();
            int yourChoice=bai1.enterNumber();
            if (yourChoice == 1)
            {
                Console.WriteLine("ax+b=0");
                Console.WriteLine("Nhập a:");
                int inputNumberA = bai1.enterNumber();
                Console.WriteLine("Nhập b:");
                int inputNumberB = bai1.enterNumber();
                double result=(-inputNumberA)/inputNumberB;
                Console.WriteLine("Nghiệm của phương trình " + inputNumberA+ "x+" + inputNumberB + "=0 là" + result);
            }else if(yourChoice == 2)
            {

                Console.WriteLine("ax^2+bx+c=0");
                Console.WriteLine("Nhập a:");
                int inputNumberA = bai1.enterNumber();
                Console.WriteLine("Nhập b:");
                int inputNumberB = bai1.enterNumber();
                Console.WriteLine("Nhập c:");
                int inputNumberC = bai1.enterNumber();
                double meTan= Math.Pow(inputNumberB, 2)-4*inputNumberA*inputNumberC;
                if(meTan > 0)
                {
                    Console.WriteLine("Phương trình có 2 nghiệm");
                    Console.WriteLine("x1="+(-inputNumberB+Math.Sqrt(meTan))/(2*inputNumberA));
                    Console.WriteLine("x2="+(-inputNumberB-Math.Sqrt(meTan))/(2*inputNumberA));
                }else if(meTan == 0) { 
                    Console.WriteLine("Phương trình nghiệm kép: x1=x2="+(-inputNumberB)/(2*inputNumberA));
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
            
            
        }
    }
}
