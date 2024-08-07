using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramework.DO
{
    public class BillStruct
    {
        public string  codeBill;
        public string codeCustomer;
        public DateTime dateExportBill;
        public double totalMoney;
        public double debt;
        public string ToString()
        {
            return codeBill+" "+codeCustomer+" "+dateExportBill+" "+totalMoney+" "+debt;
        }
    }
}
