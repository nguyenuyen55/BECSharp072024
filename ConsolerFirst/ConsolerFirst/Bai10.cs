using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{

    internal class Bai10
    {

        string[] mNumText = {"không","một","hai","ba","bốn","năm","sáu","bảy","tám","chín"};
        private string DocHangChuc(double so, bool daydu)
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
        private string DocHangTram(double so, bool daydu)
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
        private string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";
            
            int trieu = (int)Convert.ToInt64(Math.Floor((double)so / 1000000));
           
            so = so % 1000000;
            if (trieu > 0)
            {
                chuoi = DocHangTram(trieu, daydu) + " triệu";
                daydu = true;
            }
            
            int nghin =(int) Convert.ToInt64(Math.Floor((double)so / 1000));
            
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
        public string ChuyenSoSangChuoi(double so)
        {
            if (so == 0) {
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
