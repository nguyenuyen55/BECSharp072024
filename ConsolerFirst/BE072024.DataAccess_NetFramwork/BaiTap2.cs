using BE2507.Common;
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
        public static void ChuongTrinhBaiTap2()
        {
            //bai 4
            Console.WriteLine("Bài 4: Tính giai thừa của 1 số ");

            int numberGiaiThua = ValidateData.CheckValueNumber();
            Console.WriteLine("Tính giai thừa của " + numberGiaiThua + "là " + BaiTap2.TinhGiaiThuaCuaMotSo(numberGiaiThua));
            //bai 5
            Console.WriteLine("Bài 5: liệt kê tất cả các số nguyên tố nhỏ hơn n");

            int SoTuNhienN = ValidateData.CheckValueNumber();
            Console.WriteLine(BaiTap2.ListNumberNguyenToBigNumberN(SoTuNhienN));
            Console.WriteLine("Bài 6: Kiểm tra một số là số chẵn hay số lẻ ");
            BaiTap2.KiemTraSoChanHaySoLe(SoTuNhienN);
            //bai 7
            Console.WriteLine("Bài 7: Kiểm tra 1 số có phải số nguyen tố không");
            int inputNumberCheckSoNguyenTo = ValidateData.CheckValueNumber();
            Console.WriteLine(BaiTap2.checkNumberNguyenTo(inputNumberCheckSoNguyenTo));
            //Bai 8
            Console.WriteLine("Bài 8 : Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn");
            int[] myArrayNumbers = { 58, 2, 25, 50, 75, 100 };

            BaiTap2.printArrayLeVaArrayChan(myArrayNumbers);
            Console.WriteLine("Bài 9 : Cho một mảng số nguyên hãy thực hiện sắp xếp dãy tang và giảm dần");
            BaiTap2.sortArrayIncreaseAndDecrease(myArrayNumbers);
            Console.WriteLine("Bài 10: Nhập một số bất kỳ và hiển thị số bằng chữ tương ứng trong C#");
            int numberChuyenString = ValidateData.CheckValueNumber();
            Console.WriteLine(BaiTap2.ChuyenSoSangChuoi(numberChuyenString));
        }
    }
}
