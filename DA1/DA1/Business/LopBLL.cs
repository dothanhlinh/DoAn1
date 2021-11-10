using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA1.DataAccess;
using DA1.Entities;
using DA1.Business.Service_Interface;
using DA1.DataAccess.Service_Interface;
namespace DA1.Business
{
    class LopBLL:ILopBLL
    {
        private ILopDAL lopDA = new LopDAL();

        public bool checkmalop(int malop)
        {
            List<Lop> list = GetAllData();

            foreach (Lop l in list)
            {
                if (l.Malop1 == malop)
                    return true;

            }
            return false;

        }
        public List<Lop> GetAllData()
        {
            return lopDA.GetAllData();
        }
        //them
        public void Insert(Lop lop)
        {
            if (lop.Tenlop1 != "" )
            {
                lop.Tenlop1 = DA1.Utility.CongCu.ChuanHoaXau(lop.Tenlop1);
                lopDA.Insert(lop);
            }
            else
                throw new Exception("Du lieu sai");
        }
        // xóa 
        public void Delete(int malop)
        {
            int i;
            List<Lop> list = lopDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Malop1 == malop) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lopDA.UPdate(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }

        // sửa 
        public void UPdate(Lop lop)
        {
            int i;
            List<Lop> list = lopDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Malop1 == lop.Malop1) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(lop);
                lopDA.UPdate(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }


        // tìm kiếm
        public List<Lop> Timlop(Lop lop)
        {
            List<Lop> list = lopDA.GetAllData();
            List<Lop> kq = new List<Lop>();

            //Voi gai tri ngam dinh ban dau
            if (lop.Tenlop1 == null  && lop.Malop1 == 0)
            {
                kq = list;
            }
            //Tim theo ho ten
            if (lop.Tenlop1!= null && lop.Malop1 == 0)
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].Tenlop1.IndexOf(lop.Tenlop1) >= 0)
                    {
                        kq.Add(new Lop(list[i]));
                    }
            }
            //Tim theo ma
            //else if (lop.Tenlop1 == null && lop.Malop1 != 0)
            //{
            //    for (int i = 0; i < list.Count; i++)
            //        if (list[i].Malop1 == lop.Malop1)
            //        {
            //            kq.Add(new SinhVien(list[i]));
            //        }
            //}
            else kq = null;
            return kq;

        }
    }
}
