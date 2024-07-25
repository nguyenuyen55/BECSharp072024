using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork
{
    public static class BaiTap2
    {
        public static string ListNumberNguyenToBigNumberN(int n)
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
        public static bool checkSoNguyento(int inputNumbercheck)
        {
            bool IsNguyenTo = false;
            if (inputNumbercheck < 2)
            {
                return IsNguyenTo;
            }
            int soLanNumberChiaHet = 0;
            for (int i = 1; i <= inputNumbercheck; i++)
            {
                if (inputNumbercheck % i == 0)
                {
                    soLanNumberChiaHet++;
                }

            }
            if (soLanNumberChiaHet == 2)
            {
                IsNguyenTo = true;
            }
            return IsNguyenTo;
        }
        public static int TinhGiaiThuaCuaMotSo(int inputNumber)
        {
            int multiplication = 1;
            for (int i = 1; i <= inputNumber; i++)
            {
                multiplication *= i;
            }
            return multiplication;
        }
        public static string KiemTraSoChanHaySoLe(int inputNumber)
        {
            var result = inputNumber % 2 == 0 ? inputNumber + " Là số chẵn " : inputNumber + " Là số lẻ";
            return result;
        }
        public static string checkNumberNguyenTo(int inputNumber)
        {
            var result = checkSoNguyento(inputNumber) ? inputNumber + " là số nguyên tố" : inputNumber + " không phải là số nguyên tố";
            return result;
        }
        public static void printArrayLeVaArrayChan(int[] arr)
        {
            int[] arrayOdd = new int[10];
            int[] arrayOven = new int[10];
            int indexOdd = 0, indexOven = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrayOdd[indexOdd] = arr[i];
                    indexOdd++;
                }
                else
                {
                    arrayOven[indexOdd] = arr[i];
                    indexOven++;
                }
            }
            Console.WriteLine("Các phân tử của mạng chẵn là ");
            for (int i = 0; i < indexOdd; i++)
            {
                Console.Write(arrayOdd[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Các phân tử của mạng lẻ là ");
            for (int i = 0; i < indexOven; i++)
            {
                Console.Write(arrayOven[i] + " ");
            }
        }
        //Bài 9: Cho một mảng số nguyên hãy thực hiện sắp xếp dãy tang và giảm dần
        public static void sortArrayIncreaseAndDecrease(int[] inputArray)
        {
            Console.WriteLine("mảng số nguyên sắp xếp tăng dần");
            //tang dan
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[i])
                    {
                        int wrap = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = wrap;
                    }
                }
                Console.Write(inputArray[i] + " ");

            }
            Console.WriteLine("\nmảng số nguyên sắp xếp giảm dần");
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[j] > inputArray[i])
                    {
                        int wrap = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = wrap;
                    }
                }
                Console.Write(inputArray[i] + " ");

            }

        }
      static  string[] mNumText = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static string DocHangChuc(double so, bool daydu)
        {
            string chuoi = "";
            int chuc = (int)Convert.ToInt64(Math.Floor((double)(so / 10)));
            int donvi = (int)so % 10;

            if (chuc > 1)
            {
                chuoi = " " + mNumText[chuc] + " mươi";
                if (donvi == 1)
                {
                    chuoi += " mốt";
                }
            }
            else if (chuc == 1)
            {
                chuoi = " mười";
                if (donvi == 1)
                {
                    chuoi += " một";
                }
            }
            else if (daydu && donvi > 0)
            {
                chuoi = " lẻ";
            }
            if (donvi == 5 && chuc >= 1)
            {
                chuoi += " lăm";
            }
            else if (donvi > 1 || (donvi == 1 && chuc == 0))
            {
                chuoi += " " + mNumText[donvi];
            }
            return chuoi;
        }
        private static string DocHangTram(double so, bool daydu)
        {
            string chuoi = "";

            int tram = (int)Convert.ToInt64(Math.Floor((double)so / 100));

            so = so % 100;
            if (daydu || tram > 0)
            {
                chuoi = " " + mNumText[tram] + " trăm";
                chuoi += DocHangChuc(so, true);
            }
            else
            {
                chuoi = DocHangChuc(so, false);
            }
            return chuoi;
        }
        private static string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";

            int trieu = (int)Convert.ToInt64(Math.Floor((double)so / 1000000));

            so = so % 1000000;
            if (trieu > 0)
            {
                chuoi = DocHangTram(trieu, daydu) + " triệu";
                daydu = true;
            }

            int nghin = (int)Convert.ToInt64(Math.Floor((double)so / 1000));

            so = so % 1000;
            if (nghin > 0)
            {
                chuoi += DocHangTram(nghin, daydu) + " nghìn";
                daydu = true;
            }
            if (so > 0)
            {
                chuoi += DocHangTram(so, daydu);
            }
            return chuoi;
        }
        public static string ChuyenSoSangChuoi(double so)
        {
            if (so == 0)
            {
                return mNumText[0];
            }
            string chuoi = "", hauto = "";
            int ty;
            do
            {

                ty = (int)Convert.ToInt64(Math.Floor((double)so / 1000000000));

                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " tỷ";
            } while (ty > 0);
            return chuoi + " đồng";
        }
    }
}
