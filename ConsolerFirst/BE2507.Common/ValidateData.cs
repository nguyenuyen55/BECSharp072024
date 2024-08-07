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
        public static bool CheckNull_Data(string input)
        {
            return string.IsNullOrEmpty( input )?false :true;
        }

        public static bool IsNumberic(string input)
        { double n;
            bool isNumberic = double.TryParse(input, out n);
            return isNumberic;
        }
        public static bool IsDate(string input)
        {
            DateTime dateValue;
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy",new CultureInfo("es-US"),DateTimeStyles.None,out dateValue))
            {
                return false;

            }
            return true;
        }

    }
}
