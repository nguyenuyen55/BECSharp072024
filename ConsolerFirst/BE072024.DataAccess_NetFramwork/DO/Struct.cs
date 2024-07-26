using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2507.Common
{
    public struct PhanSo
    {
        public int tu;
     public   int mau;
        public PhanSo(int _tu, int _phan)
        {
            this.tu= _tu;
            this.mau= _phan;
        }
        public string ToString()
        {
            return tu + "/" + mau;
        }
    }
}
