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
            int yourChoice= Convert.ToInt32(Console.ReadLine());
            if (yourChoice == 1)
            {
                Console.WriteLine("ax+b=0");
                Console.WriteLine("Nhập a:");
                int a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập b:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nghiệm của phương trình " + a + "x+" + b + "=0 là" + (-b / a));
            }else if(yourChoice == 2)
            {

                Console.WriteLine("ax^2+bx+c=0");
                Console.WriteLine("Nhập a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập b:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập c:");
                int c = Convert.ToInt32(Console.ReadLine());
                double meTan= Math.Pow(b, 2)-4*a*c;
                if(meTan > 0)
                {
                    Console.WriteLine("Phương trình có 2 nghiệm");
                    Console.WriteLine("x1="+(-b+Math.Sqrt(meTan))/(2*a));
                    Console.WriteLine("x2="+(-b-Math.Sqrt(meTan))/(2*a));
                }else if(meTan == 0) { 
                    Console.WriteLine("Phương trình nghiệm kép: x1=x2="+(-b)/(2*a));
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
            
        }
    }
}
