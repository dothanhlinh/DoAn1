using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA1.Entities;
using DA1.DataAccess;

namespace DA1.Business.Service_Interface
{
    interface ILopBLL
    {
        List<Lop> GetAllData();
        void Insert(Lop lop);
        void Delete(int malop);
        void UPdate(Lop lop);
        List<Lop> Timlop(Lop listlop);
    }
}
