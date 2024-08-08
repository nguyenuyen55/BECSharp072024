using BE072024.DataAccess_NetFramework.DO;
using BE072024.DataAccess_NetFramwork.DO;
using BE2507.Common;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramework.Business
{
    public class BillBusiness
    {
        List<BillStruct> billStructs = new List<BillStruct>();
        List<HistoryBillContact> historyBillStructs = new List<HistoryBillContact>();
        public ReturnData NhapTuExcelFile(string filepath)
        {
            var returnData=new ReturnData();
            var itemError = new StringBuilder();
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                FileInfo existingFile= new FileInfo(filepath);

                using (ExcelPackage package = new ExcelPackage(existingFile)) { 
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int colCount = worksheet.Dimension.End.Column; //get cột
                    int rowCount=worksheet.Dimension.End.Row;  //get hàng ngang

                    for (int row = 2; row <= rowCount; row++)
                    {
                        //get row lấy dữ liệu từ dùng số 2 bỏ qua tiêu đề
                        // lấy dữ liệu theo hàng và cột
                        var maBill= worksheet.Cells[row,1].Value?.ToString().Trim();
                        var maCustomer= worksheet.Cells[row,2].Value?.ToString().Trim();
                        var dateExport= worksheet.Cells[row,3].Value?.ToString().Trim();
                        var TongMoney=  worksheet.Cells[row,4].Value?.ToString().Trim();
                        var debt= worksheet.Cells[row,5].Value?.ToString().Trim();
                        if (!BE2507.Common.ValidateData.CheckNull_Data(maBill) || !BE2507.Common.ValidateData.CheckNull_Data(maCustomer) || !BE2507.Common.ValidateData.CheckNull_Data(dateExport)||
                            !BE2507.Common.ValidateData.CheckNull_Data(TongMoney)|| !BE2507.Common.ValidateData.CheckNull_Data(debt))
                        {
                            itemError.Append("Hàng số" + row + " cột số "+row+" bị trống");
                            continue;
                        }

                        if (!BE2507.Common.ValidateData.IsDate(dateExport))
                        {
                            itemError.Append("Hàng số" + row + " cột số " + row + " không đúng định dạng camera");
                            continue;
                        }
                        BillStruct billStruct = new BillStruct();
                        billStruct.codeBill = maBill;
                        billStruct.codeCustomer=maCustomer;
                        billStruct.totalMoney = double.Parse(TongMoney);
                        billStruct.debt = double.Parse(debt);
                        billStruct.dateExportBill = Convert.ToDateTime(dateExport);
                         billStructs.Add(billStruct);
                    }
                }
                if(itemError.Length!=0)
                {
                    returnData.ReturnCode = (int)CodeError.THAT_BAI;
                    returnData.ReturnMsg = itemError.ToString();
                    return returnData;

                }
            }
            catch (Exception ex) {
                returnData.ReturnCode = (int)CodeError.EXCEPTION;
                returnData.ReturnMsg = ex.StackTrace;
                return returnData;
            }

            returnData.ReturnCode = (int)CodeError.THANH_CONG;
            returnData.ReturnMsg = "Thêm thành công";
            return returnData;
        }
        public List<BillStruct> ListBill()
        {
            var list = new List<BillStruct>();
            if (billStructs == null || billStructs.Count <= 0)
            {
                return list;
            }
            for (int i = 0; i < billStructs.Count; i++)
            {

                list.Add(billStructs[i]);

            }
            return list;
        }
         public ReturnData nhapTuongTacHoaDon()
           
        { var returnData = new ReturnData();
            try
            {
                Console.WriteLine("nhập phương thức liên hệ ");
                string codeBill_Input = Console.ReadLine();
                while (!checkCodeBillExsits(codeBill_Input))
                {
                    Console.WriteLine("không tồn tại mã này vui lòng nhập lại");
                    codeBill_Input = Console.ReadLine();
                }
                Console.WriteLine("nhập tên nhân viên liên hệ ");
                string nameEmployee = Console.ReadLine();
                Console.WriteLine("nhập phương thức liên hệ ");
                Console.WriteLine("1. gọi điện");
                Console.WriteLine("2. gửi mail");
                Console.WriteLine("3. gặp trực tiếp ");
                int choicecontact = ValidateData.CheckValueNumber();
                string methodContact = "";
                switch (choicecontact)
                {
                    case 1: methodContact = "gọi điện"; break;
                    
                }

                var historybillContact = new HistoryBillContact();
                historybillContact.codeBill = codeBill_Input;
                historybillContact.nameEmployee = nameEmployee;
                historybillContact.methodContact = methodContact;
                historyBillStructs.Add(historybillContact);
                returnData.ReturnCode = 1;
                returnData.ReturnMsg = "THêm thành công";
                return returnData;
            }
            catch
            {
                returnData.ReturnCode = -100;
                returnData.ReturnMsg = "thêm thất bại";
                return returnData;
            }
            
        }

        public bool checkCodeBillExsits(string billCode)
        {
            bool codeBillExsit=false;
            foreach(var itemBill in billStructs)
            {
                if(itemBill.codeBill==billCode.Trim())
                {
                    codeBillExsit=true;
                    break;
                }
            }
            return codeBillExsit;
        }

        public ReturnData xuatFileExcel()
        {
            var returnData = new ReturnData();
            try
            {
                ExcelPackage excelPackage = new ExcelPackage();
                ExcelWorksheet sheet = excelPackage.Workbook.Worksheets.Add("Report Bill");
                sheet.Cells["A1"].Value = "Mã hóa đơn";
                sheet.Cells["B1"].Value = "Nhân viên";
                sheet.Cells["C1"].Value = "phương thức liên hệ";

                //thêm header cho file excel

                int row = 2;
                if (historyBillStructs.Count > 0)
                {
                    foreach (var itemBill in historyBillStructs)
                    {
                        sheet.Cells[string.Format("A{0}", row)].Value = itemBill.codeBill;
                        sheet.Cells[string.Format("B{0}", row)].Value = itemBill.nameEmployee;
                        sheet.Cells[string.Format("C{0}", row)].Value = itemBill.methodContact;
                        row++;
                    }
                }
                sheet.Cells["A:AZ"].AutoFitColumns();
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\uyengf.xlsx";
                excelPackage.SaveAs(filePath);
                returnData.ReturnCode=1;
                returnData.ReturnMsg= $"Excel file '{filePath}' has been created successfully.";
                return returnData;
            }
            catch
            {
                returnData.ReturnCode = -100;
                returnData.ReturnMsg = "xuất thất bại xin vui lòng kiểm tra lại";
                return returnData;

            }



        }
    }
}
