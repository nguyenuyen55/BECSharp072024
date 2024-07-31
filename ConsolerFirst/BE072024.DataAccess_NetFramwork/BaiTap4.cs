using BE072024.DataAccess_NetFramwork.DO;
using BE2507.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Globalization;

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
            switch(choice)
            {
                case 1: nhapDSNhanVien();
                    menu();  break;
                case 2: readFromExcel(); menu(); break;
                case 3: xuatDanhSach(); menu(); break;
                case 4: xuatExcelNhanVienFiveTenYears(); menu(); break;
                case 5:  break;


            }
        }
        public void nhapDSNhanVien()
        {
            Console.WriteLine("Bạn nhập khoảng bao nhiêu nhân viên : ");
            int countEmployee =ValidateData.CheckValueNumber();
            nhanViens = new NhanVien[countEmployee];
            for (int i = 0; i < countEmployee; i++) { 
                Console.WriteLine("nhập mã nhân viên "+(i+1));
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
               
                NhanVien nhanVien = new NhanVien(codeEmployee,FullNameEmployee,dateEnterCompany, NhanVien.getStructChucvu(chucvu));
                nhanViens[i]= nhanVien;
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
       public void readFromExcel()
        {
            Excel.Application excelApp= new Excel.Application();
            Excel.Workbook excelWB = excelApp.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\InFormationee.xlsx");
            Excel._Worksheet excelWS = excelWB.Sheets[1];
            Excel.Range excelRange = excelWS.UsedRange;
            int rowCount = excelRange.Rows.Count;
            int columnCount = excelRange.Columns.Count;

            for (int i = 2; i <= rowCount; i++)
            {

                NhanVien employeeItem = new NhanVien();
                employeeItem.codeEmployee = excelRange.Cells[i, 1].value.ToString();
                employeeItem.name = excelRange.Cells[i, 2].value.ToString();
                employeeItem.tenChucVu = NhanVien.getStructChucvu(excelRange.Cells[i, 3].value.ToString());
                employeeItem.dateEnterCompany = excelRange.Cells[i, 4].value.ToString();
                AddElemenet(employeeItem);
            }
            Marshal.ReleaseComObject(excelWS);
            Marshal.ReleaseComObject(excelRange);
            excelWB.Close();
            Marshal.ReleaseComObject(excelWB);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
            xuatDanhSach();
        }   
        void xuatDanhSach()
        {
            for (int i = 0; i < nhanViens.Length; i++) {
                Console.WriteLine(nhanViens[i].codeEmployee);
                Console.WriteLine(nhanViens[i].name);
                Console.WriteLine(nhanViens[i].getChucvu(nhanViens[i].tenChucVu));
                Console.WriteLine(nhanViens[i].dateEnterCompany);
                Console.WriteLine("----------------------------");
            }
        }
         void AddElemenet(NhanVien employee)
        {
            if (nhanViens == null)
            {
                nhanViens = new NhanVien[] {employee };
            }
            else
            {
                NhanVien[] newNhanViens= new NhanVien[nhanViens.Length+1];
                Array.Copy(nhanViens,newNhanViens,nhanViens.Length);
                newNhanViens[newNhanViens.Length-1] = employee;

                nhanViens = newNhanViens;
            }
        }

      public  void xuatExcelNhanVienFiveTenYears()
        {
           
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            // Thêm một Workbook
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Yearly Data";
            // Thêm tiêu đề cột
            worksheet.Cells[1, 1] = "ID";
            worksheet.Cells[1, 2] = "Name";
            worksheet.Cells[1, 3] = "Position";
            worksheet.Cells[1, 4] = "Date Enter Company";
            int rowCurrent = 2;
            // Thêm dữ liệu
            for (int i = 0; i < nhanViens.Length; i++)
            {
                DateTime dateEnterCompany = DateTime.ParseExact(nhanViens[i].dateEnterCompany, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int yearsOfWork = DateTime.Now.Year - dateEnterCompany.Year;
                if( yearsOfWork >=5 )
                {
                    worksheet.Cells[rowCurrent, 1] = nhanViens[i].codeEmployee;
                    worksheet.Cells[rowCurrent, 2] = nhanViens[i].name;
                    worksheet.Cells[rowCurrent, 3] = nhanViens[i].getChucvu(nhanViens[i].tenChucVu);
                    worksheet.Cells[rowCurrent, 4] = nhanViens[i].dateEnterCompany;
                    rowCurrent++;
                }
               
            }
            
            // Định dạng tiêu đề cột
            Excel.Range headerRange = worksheet.Range["A1", "B1"];
            headerRange.Font.Bold = true;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tự động điều chỉnh độ rộng cột
            worksheet.Columns.AutoFit();

            // Lưu tệp Excel
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\YearlyData.xlsx";
            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();

            Console.WriteLine($"Excel file '{filePath}' has been created successfully.");

        }
    }
}
