using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2507.Common
{
    public static class ValidateData
    {
        public static int CheckValueNumber()
        {
            Console.WriteLine("Vui lòng nhập 1 số :");
            string inputString = Console.ReadLine();
            int parsedNumber;
            while (!int.TryParse(inputString, out parsedNumber))
            {
                Console.WriteLine("Bạn vừa nhập không phải là số, vui lòng nhập lại.");
                inputString = Console.ReadLine();
            }
            return parsedNumber;
        }
        public static bool CheckValueDate(string date) {
            bool checkValDate = DateTime.TryParseExact(
               date,
               "dd/MM/yyyy",
               CultureInfo.InvariantCulture,
               DateTimeStyles.None,
               out DateTime result
           );
            return checkValDate;
        }
    }
}
