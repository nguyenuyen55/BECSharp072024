using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    //  Bài 5: Viết chương trình C# liệt kê tất cả các số nguyên tố nhỏ hơn n
    internal class Bai5
    {
        public string ListNumberNguyenToBigNumberN(int n)
        {
            string listString = "";
            for (int i = 1; i < n; i++)
            {
                if (checkSoNguyento(i))
                {
                    listString += i + ",";
                }
            }
            return listString.Remove(listString.Length - 1);
        }
        public bool checkSoNguyento(int inputNumbercheck)
        {
            bool IsNguyenTo = false;
            if (inputNumbercheck < 2)
            {
                return IsNguyenTo;
            }
            int soLanNumberChiaHet = 0;
            for (int i = 1; i <= inputNumbercheck; i++)
            {
                if(inputNumbercheck%i == 0)
                {
                    soLanNumberChiaHet++;
                }
                
            }
            if(soLanNumberChiaHet == 2) { 
            IsNguyenTo=true;
            }
            return IsNguyenTo;
        }
    }
}
