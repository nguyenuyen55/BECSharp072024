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
    enum HocLuc
    {
        XuatSac,
        Gioi,
        Kha,
        TrungBinh,
        Yeu
    }
}
