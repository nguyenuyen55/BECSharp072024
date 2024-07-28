using BE2507.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork
{
    //Bài 1: Hãy định nghĩa kiểu dữ liệu PhanSo đại diện cho kiểu phân số.
    //    Qua đó, viết chương trình cho phép người dùng thực hiện các phép cộng,
    //    trừ, nhân, chia 2 phân số.
  public  static class BaiTap3
    {
        public static PhanSo congPhanSo(PhanSo PhanSoFirst,PhanSo PhanSoSecond)
        {
             int resultTu=(PhanSoFirst.tu * PhanSoSecond.mau) + (PhanSoFirst.mau * PhanSoSecond.tu);
            int resultMau= (PhanSoFirst.mau * PhanSoSecond.mau);
            PhanSo phanSoResutl= new PhanSo(resultTu,resultMau);
            return phanSoResutl;

        }
       
        public static PhanSo nhanPhanSo(PhanSo PhanSoFirst, PhanSo PhanSoSecond)
        {
            int resultTu = (PhanSoFirst.tu * PhanSoSecond.tu) ;
            int resultMau = (PhanSoFirst.mau * PhanSoSecond.mau);
            PhanSo phanSoResutl = new PhanSo(resultTu, resultMau);
            return phanSoResutl;
        }
        public static PhanSo truPhanSo(PhanSo PhanSoFirst, PhanSo PhanSoSecond)
        {
            int resultTu = (PhanSoFirst.tu * PhanSoSecond.mau);
            int resultMau = (PhanSoFirst.mau * PhanSoSecond.tu);
            PhanSo phanSoResutl = new PhanSo(resultTu, resultMau);
            return phanSoResutl;
        }
  

public static PhanSo chiaPhanSo(PhanSo PhanSoFirst, PhanSo PhanSoSecond)
        {
            int resultTu = (PhanSoFirst.tu * PhanSoSecond.mau) - (PhanSoFirst.mau * PhanSoSecond.tu);
            int resultMau = (PhanSoFirst.mau * PhanSoSecond.mau);
            PhanSo phanSoResutl = new PhanSo(resultTu, resultMau);
            return phanSoResutl;

        }
        public static PhanSo enterPhanSo()
        {
            Console.WriteLine("Nhập tử của phân số");
            int tu1 = ValidateData.CheckValueNumber();
            Console.WriteLine("Nhập mẫu của phân số");
            int mau1 = ValidateData.CheckValueNumber();
            while (mau1 == 0)
            {
                Console.WriteLine("Nhập mẫu của phân số không được bằng 0");
                 mau1 = ValidateData.CheckValueNumber();
            }
            PhanSo PhanSo = new PhanSo(tu1,mau1);
            return PhanSo;
        }
        public static PhanSo toiGianPhanSo(PhanSo PhanSo)
        {
            int uocSoChungLonNhat=0;
            int tu = PhanSo.tu;
            int mau = PhanSo.mau;
            while (tu!=mau &&tu!=0&&mau!=0)
            {
                if (tu > mau)
                {
                    tu = tu - mau;
                }
                else
                {
                    mau=mau - tu;
                }
            }
            uocSoChungLonNhat = tu;
            if (uocSoChungLonNhat > 0)
            {
                PhanSo.tu=PhanSo.tu/uocSoChungLonNhat;
                PhanSo.mau=PhanSo.mau/uocSoChungLonNhat;
            }
            return PhanSo;
        }
        public static void ChuongTrinhBaiTap3()
        {
           PhanSo PhanSoFirst= enterPhanSo();
            PhanSo PhanSoSecond= enterPhanSo();
            Console.WriteLine("Phép cộng"+congPhanSo(PhanSoFirst, PhanSoSecond).ToString());
            Console.WriteLine("phân số rút gọn"+ toiGianPhanSo(congPhanSo(PhanSoFirst, PhanSoSecond)).tu+"/"+ toiGianPhanSo(congPhanSo(PhanSoFirst, PhanSoSecond)).mau);
            Console.WriteLine("Phép nhân" + nhanPhanSo(PhanSoFirst, PhanSoSecond).ToString());
            Console.WriteLine("Phép trừ" + truPhanSo(PhanSoFirst, PhanSoSecond).ToString());
            Console.WriteLine("Phép chia" + chiaPhanSo(PhanSoFirst, PhanSoSecond).ToString());
        }
    }
}
