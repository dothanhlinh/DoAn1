using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA1.DataAccess;
using DA1.Entities;

namespace DA1.Business.Service_Interface
{
    interface ISinhVienBLL
    {
        List<SinhVien> GetAllData();
        void Insert(SinhVien sv);
        void Delete(int masv);
        void UPdate(SinhVien sv);
        List<SinhVien> TimSinhVien(SinhVien sv);
    }
}
