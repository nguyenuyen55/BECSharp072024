using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2507.Common
{
    public static class ValidateData
    {
        public static int enterNumber()
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
    }
}
