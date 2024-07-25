using BE072024.DataAccess_NetFramwork;
using BE2507.Common;
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
            Console.OutputEncoding = Encoding.UTF8;
            //bai 1
            Console.WriteLine("Bài 1:  tìm tổng hai số , tích 2 số , hiệu 2 số ");
            int numberFirst = ValidateData.enterNumber();
            int nuberSecond = ValidateData.enterNumber();
            Console.WriteLine("a + b = " + BaiTap1.sum(numberFirst, nuberSecond));
            Console.WriteLine("a * b = " + BaiTap1.multiplication(numberFirst, nuberSecond));
            Console.WriteLine("a / b = " + BaiTap1.division(numberFirst, nuberSecond));
            //bai 2
            Console.WriteLine("Bài 2");

            BaiTap1.phuongTrinh();
            //bai 3
            Console.WriteLine("Bài 3");

            BaiTap1.ChuyenDoiCVaF();
            //bai 4
            Console.WriteLine("Bài 4: Tính giai thừa của 1 số ");

            int numberGiaiThua = ValidateData.enterNumber();
            Console.WriteLine("Tính giai thừa của " + numberGiaiThua + "là " + BaiTap2.TinhGiaiThuaCuaMotSo(numberGiaiThua));
            //bai 5
            Console.WriteLine("Bài 5: liệt kê tất cả các số nguyên tố nhỏ hơn n");

            int SoTuNhienN = ValidateData.enterNumber();
            Console.WriteLine(BaiTap2.ListNumberNguyenToBigNumberN(SoTuNhienN));
            Console.WriteLine("Bài 6: Kiểm tra một số là số chẵn hay số lẻ ");
            BaiTap2.KiemTraSoChanHaySoLe(SoTuNhienN);
            //bai 7
            Console.WriteLine("Bài 7: Kiểm tra 1 số có phải số nguyen tố không");
            int inputNumberCheckSoNguyenTo = ValidateData.enterNumber();
            Console.WriteLine(BaiTap2.checkNumberNguyenTo(inputNumberCheckSoNguyenTo));
            //Bai 8
            Console.WriteLine("Bài 8 : Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn");
            int[] myArrayNumbers = { 58, 2, 25, 50, 75, 100 };
            
            BaiTap2.printArrayLeVaArrayChan(myArrayNumbers);
            Console.WriteLine("Bài 9 : Cho một mảng số nguyên hãy thực hiện sắp xếp dãy tang và giảm dần");
            BaiTap2.sortArrayIncreaseAndDecrease(myArrayNumbers);
            Console.WriteLine("Bài 10: Nhập một số bất kỳ và hiển thị số bằng chữ tương ứng trong C#");
            int numberChuyenString = ValidateData.enterNumber();
            Console.WriteLine(BaiTap2.ChuyenSoSangChuoi(numberChuyenString)) ;
         
            Console.ReadKey();
        }
    }
}
