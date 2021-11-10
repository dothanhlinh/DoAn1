using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA1.Entities;

namespace DA1.DataAccess.Service_Interface
{
    interface ILopDAL
    {
        List<Lop> GetAllData();
        void Insert(Lop l);
        void Delete(int malop);
        void UPdate(List<Lop> listlop);
    }
}
