using System;
using System.Collections.Generic;
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
            string day=date.Substring(0, 2);
            string month=date.Substring(3, 2);
            string year=date.Substring(6, 4);
            if (date.Count(x => x == '/') != 2)
            {
                return false;
            }
            if (day.Contains('/')|| month.Contains('/')|| year.Contains('/'))
            {
                return false;
            }
            
            return true;
        }
    }
}
