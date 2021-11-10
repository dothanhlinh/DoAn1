using System;
using System.Collections.Generic;
using System.Text;
using DA1.DataAccess;
using DA1.Entities;
namespace DA1.DataAccess.Service_Interface
{
    interface ISinhVienDAL
    {
        List<SinhVien>GetAllData();
        void Insert(SinhVien sv);
        void Delete(int masv);
        void UPdate(List<SinhVien> listsv);
    }
}
