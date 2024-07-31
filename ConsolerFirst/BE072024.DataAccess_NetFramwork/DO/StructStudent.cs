using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork.DO
{

    public struct SinhVien
    {
        int id;
        string name;
        int age;
        double diemTrungBinhHK1;
        double diemTrungBinhHK2;
    }
    public struct NhanVien
    {
        public string codeEmployee;
        public string name;
        public string dateEnterCompany;
      public chucVu tenChucVu;
        public float heSo
        {
            get { return getHeSo(this.tenChucVu); }
            
        }
        //public chucVu tenChucVu
        //{
        //    set; get { return getChucvu(this.tenChucVu); }

        //}
        public NhanVien(string _codeEmployee, string _name, string _dateEnterCompany, chucVu _tenChucVu)
        {
            this.codeEmployee = _codeEmployee;
            this.name = _name;
            this.dateEnterCompany = _dateEnterCompany;
            this.tenChucVu = _tenChucVu;
           
        }

        public float getHeSo(chucVu tenchucvu)
        {
            switch(tenchucvu)
            {
                case chucVu.NhanVien:
                    return 1.0f;
                case chucVu.QuanLy:
                    return 1.5f;
                case chucVu.GiamDoc:
                    return 2.0f;
                default:
                    return 1.0f;
            }
        }
        public string getChucvu(chucVu tenchucvu)
        {
            switch (tenchucvu)
            {
                case chucVu.NhanVien:
                    return "Nhân Viên";
                case chucVu.QuanLy:
                    return "Quản lý";
                case chucVu.GiamDoc:
                    return "Giám Đốc";
                default:
                    return "Nhân Viên";
            }
        }
        public static chucVu getStructChucvu(string tenchucvu)
        {
            switch (tenchucvu)
            {
                case "Nhân Viên":
                    return chucVu.NhanVien;
                case "Quản lý":
                    return chucVu.QuanLy;
                case "Giám Đốc":
                    return chucVu.GiamDoc;
                default:
                    return chucVu.NhanVien;
            }
        }
    }
    enum HocLuc
    {
        XuatSac,
        Gioi,
        Kha,
        TrungBinh,
        Yeu
    }
    public enum chucVu
    {  NhanVien =1,
        QuanLy=2 ,
        GiamDoc=3 

    }
}
