using BE072024.DataAccess_NetFramwork.DO;
using BE2507.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork
{
    public class BaiTap4
    {
        NhanVien[] nhanViens;
        List<NhanVien> listNhanViens;
        public void menu()
        {
            Console.WriteLine("Chương Trình Bài Tập 4");
            Console.WriteLine("1.Nhập danh sách nhân viên từ bàn phím");
            Console.WriteLine("2.Nhập danh sách nhân viên từ excel");
            Console.WriteLine("3. Hiển thị danh sách nhân viên");
            Console.WriteLine("4. Xuất file excel danh sách các nhân viên theo các mốc 5 năm và 10 năm");
            Console.WriteLine("5. Thoát chương trình ");
            Console.WriteLine("Bạn chọn yêu cầu gì : ");

            int choice = ValidateData.CheckValueNumber();
            if(choice == 1)
            {
                nhapDSNhanVien();
            }
        }
        public void nhapDSNhanVien()
        {
            Console.WriteLine("Bạn nhập khoảng bao nhiêu nhân viên : ");
            int countEmployee =ValidateData.CheckValueNumber();
            for (int i = 0; i < countEmployee; i++) { 
                Console.WriteLine("nhập mã nhân viên ");
                string codeEmployee = Console.ReadLine();
                Console.WriteLine("nhập họ và tên nhân viên ");
                string FullNameEmployee = Console.ReadLine();
            
                Console.WriteLine("nhập chức vụ nhân viên ");
                string chucvu = enterPosition();
                Console.WriteLine("nhập ngày vào công ty nhập theo mẫu sau : 01/01/2024:");
                string dateEnterCompany = Console.ReadLine();
                while (!ValidateData.CheckValueDate(dateEnterCompany))
                {
                    Console.WriteLine("Nhập sai định dạng vui lòng nhập lại:");
                    dateEnterCompany = Console.ReadLine();
                }
            
                NhanVien nhanVien = new NhanVien(codeEmployee,FullNameEmployee,dateEnterCompany, chucVu.GiamDoc);
                nhanViens[i]= nhanVien;
            }
            for (int i = 0; i < countEmployee; i++)
            {
                Console.Write("{0} - {1} - {2} - {3} - {4} - {5}", nhanViens[i].codeEmployee, nhanViens[i].name, nhanViens[i].dateEnterCompany, nhanViens[i].tenChucVu, nhanViens[i].heSo);
            }
        }
        string enterPosition()
        {
            Console.WriteLine("1 . Nhân Viên");
            Console.WriteLine("2 . Quản lí");
            Console.WriteLine("3 . Giám đốc");
            int choice = ValidateData.CheckValueNumber();
            while (choice <0 || choice>3)
            {
                Console.WriteLine("Vui lòng chọn lựa trên 1,2 hoặc 3");
                choice = ValidateData.CheckValueNumber();
            }
            switch(choice)
            {
                case (int) chucVu.GiamDoc:
                    return "Giám Đốc";
                case (int)chucVu.QuanLy:
                    return "Quản lý";
                default:
                    return "Nhân viên";
            }
        }
        
    }
}
