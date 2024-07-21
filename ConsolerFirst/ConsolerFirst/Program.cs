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
            ////bai 1
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Tính toán các phép tính");

            Bai1 bai1 = new Bai1();
            //int numberFirst =bai1.enterNumber();
            //int nuberSecond =bai1.enterNumber();

            //Console.WriteLine("a + b = " + bai1.sum(numberFirst, nuberSecond));
            //Console.WriteLine("a * b = " + bai1.multiplication(numberFirst, nuberSecond));
            //Console.WriteLine("a / b = " + bai1.division(numberFirst, nuberSecond));
            //Bai2 bai2 = new Bai2();
            //bai2.phuongTrinh();
            ////Bai3 bai3 = new Bai3();
            ////bai3.ChuyenDoiCVaF();
            //Bai4 bai4 = new Bai4();
            //int numberGiaiThua = bai1.enterNumber();
            //Console.WriteLine("Tính giai thừa của "+numberGiaiThua +"là "+ bai4.TinhGiaiThuaCuaMotSo(numberGiaiThua));
            Bai5 bai5 = new Bai5();
            int n = bai1.enterNumber();
            Console.WriteLine(bai5.ListNumberNguyenToBigNumberN(n));
            Console.ReadKey();


        }
    }
}
