using BE072024.DataAccess_NetFramework.Business;
using BE072024.DataAccess_NetFramework.DO;
using BE072024.DataAccess_NetFramwork;
using BE072024.DataAccess_NetFramwork.Business;
using BE072024.DataAccess_NetFramwork.DO;
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
            //BaiTap1.ChuongTrinhBaiTap1();
            //BaiTap2.ChuongTrinhBaiTap2();
            //BaiTap3.ChuongTrinhBaiTap3();
            //BaiTap4 baiTap4 = new BaiTap4();
            //  baiTap4.nhapDSNhanVien();
            //baiTap4.menu();

            //var billStruct = new BillBusiness();
            //var filePath = @"C:\Users\uyen.nguyen\source\repos\nguyenuyen55\BECSharp072024\ConsolerFirst\BE072024.DataAccess_NetFramwork\Template\BillList.xlsx";
            //Console.WriteLine(billStruct.NhapTuExcelFile(filePath).ReturnMsg);

            //Console.WriteLine(billStruct.nhapTuongTacHoaDon().ReturnMsg);
            //Console.WriteLine(billStruct.xuatFileExcel().ReturnMsg);

            MyStack<int> stack = new MyStack<int>();
            Console.WriteLine("Bài tập 1 của bt 6");
            stack.Push(1);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());

            BaiTap6Business baiTap6Business = new BaiTap6Business();
            Dictionary<int, Student> listStudents = baiTap6Business.initListStudent();
            baiTap6Business.FindStudentGradeHigh(listStudents,0);
            baiTap6Business.FindStudentGradeHigh(listStudents,5);
            Console.WriteLine("Danh sách nhân viên có điểm trung bình lớn hơn 5 :");
            Console.WriteLine( baiTap6Business.countCaoHonTB(listStudents));
            Console.ReadKey();
        }
    }
}
