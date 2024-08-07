using BE072024.DataAccess_NetFramework.DO;
using BE072024.DataAccess_NetFramwork.DO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramework.Business
{
    public class BillBusiness
    {
        List<BillStruct> billStructs = new List<BillStruct>();
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

        
    }
}
