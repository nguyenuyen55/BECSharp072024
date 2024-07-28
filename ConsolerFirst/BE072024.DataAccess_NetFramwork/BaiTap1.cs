using BE2507.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork
{
    public static class BaiTap1
    {
        public static int sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int division(int number1, int number2)
        {
            return number1 * number2;
        }
        public static void phuongTrinh()
        {
            Console.WriteLine("Bạn muốn giải phương trình nào ?");
            Console.WriteLine("1. Phương trình bậc 1: ax+b=0.");
            Console.WriteLine("2. Phương trình bậc 2 ax^2+bx+c=0.");
            Console.Write("Nhập lựa chọn của bạn : ");
           
            int yourChoice = ValidateData.CheckValueNumber();
            if (yourChoice == 1)
            {
                Console.WriteLine("ax+b=0");
                Console.WriteLine("Nhập a:");
                int inputNumberA = ValidateData.CheckValueNumber();
                Console.WriteLine("Nhập b:");
                int inputNumberB = ValidateData.CheckValueNumber();
                double result = (-inputNumberA) / inputNumberB;
                Console.WriteLine("Nghiệm của phương trình " + inputNumberA + "x+" + inputNumberB + "=0 là" + result);
            }
            else if (yourChoice == 2)
            {

                Console.WriteLine("ax^2+bx+c=0");
                Console.WriteLine("Nhập a:");
                int inputNumberA = ValidateData.CheckValueNumber();
                Console.WriteLine("Nhập b:");
                int inputNumberB = ValidateData.CheckValueNumber();
                Console.WriteLine("Nhập c:");
                int inputNumberC = ValidateData.CheckValueNumber();
                double meTan = Math.Pow(inputNumberB, 2) - 4 * inputNumberA * inputNumberC;
                if (meTan > 0)
                {
                    Console.WriteLine("Phương trình có 2 nghiệm");
                    Console.WriteLine("x1=" + (-inputNumberB + Math.Sqrt(meTan)) / (2 * inputNumberA));
                    Console.WriteLine("x2=" + (-inputNumberB - Math.Sqrt(meTan)) / (2 * inputNumberA));
                }
                else if (meTan == 0)
                {
                    Console.WriteLine("Phương trình nghiệm kép: x1=x2=" + (-inputNumberB) / (2 * inputNumberA));
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }


        }
        public static void ChuyenDoiCVaF()
        {
            Console.WriteLine("1. Đổi C sang F.");
            Console.WriteLine("2. Đổi F sang C.");
            Console.WriteLine("Vui lòng lựa chọn : ");
            int yourChoice = ValidateData.CheckValueNumber();
            if (yourChoice == 1)
            {
                Console.WriteLine("Nhập độ C : ");
                int inputNumberC = ValidateData.CheckValueNumber();
                Console.WriteLine(" Đổi C sang F: " + inputNumberC + "C= " + inputNumberC * 33.8 + "F");
            }
            else if (yourChoice == 2)
            {
                Console.WriteLine("Nhập độ F : ");
                int inputNumberF = ValidateData.CheckValueNumber();
                Console.WriteLine(" Đổi F sang C: " + inputNumberF + "F= " + inputNumberF * (-17.22222) + "C");
            }
        }


        public static void ChuongTrinhBaiTap1()
        {
            Console.WriteLine("Bài 1:  tìm tổng hai số , tích 2 số , hiệu 2 số ");
            int numberFirst = ValidateData.CheckValueNumber();
            int nuberSecond = ValidateData.CheckValueNumber();
            Console.WriteLine("a + b = " + sum(numberFirst, nuberSecond));
            Console.WriteLine("a * b = " + multiplication(numberFirst, nuberSecond));
            Console.WriteLine("a / b = " + division(numberFirst, nuberSecond));
            //bai 2
            Console.WriteLine("Bài 2");
            phuongTrinh();
            //bai 3
            Console.WriteLine("Bài 3");
            ChuyenDoiCVaF();
        }
 
    }
}
