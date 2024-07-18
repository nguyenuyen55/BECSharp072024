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
            //bai 1
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tính toán các phép tính");
            Console.Write("Nhập a: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhập b: ");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        Bai1 bai1 = new Bai1();
                        Console.WriteLine("a + b = "+bai1.sum(number1, number2));
                        Console.WriteLine("a * b = " + bai1.multiplication(number1, number2));
                        Console.WriteLine("a / b = " + bai1.division(number1, number2));
            Bai2 bai2 = new Bai2();
            bai2.phuongTrinh();
            Bai3 bai3 = new Bai3();
            bai3.ChuyenDoiCVaF();

            Console.ReadLine();


        }
    }
}
