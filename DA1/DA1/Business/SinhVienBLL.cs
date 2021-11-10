using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA1.DataAccess;
using DA1.Business;
using DA1.Entities;
using DA1.DataAccess.Service_Interface;
namespace DA1.Business.Service_Interface
{
    class SinhVienBLL : ISinhVienBLL
    {
        private ISinhVienDAL svDA = new SinhVienDAL();
        public bool checkmasv(int masv)
        {
            List<SinhVien> list = GetAllData();

            foreach (SinhVien sv in list)
            {
                if (sv.Ma_sv1 == masv)
                    return true;

            }
            return false;

        }
        public List<SinhVien> GetAllData()
        {
            return svDA.GetAllData();
        }
        //them
        public void Insert(SinhVien sv)
        {
            if (sv.Ten_sv1 != "" && sv.Que_quan1 != "")
            {
                sv.Ten_sv1 = DA1.Utility.CongCu.ChuanHoaXau(sv.Ten_sv1);
                sv.Que_quan1 = DA1.Utility.CongCu.ChuanHoaXau(sv.Que_quan1);
                svDA.Insert(sv);
            }
            else
                throw new Exception("Du lieu sai");
        }
        // xóa 
        public void Delete(int masv)
        {
            int i;
            List<SinhVien> list = svDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Ma_sv1 == masv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                svDA.UPdate(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
    
        // sửa 
        public void UPdate(SinhVien sv)
        {
            int i;
            List<SinhVien> list = svDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Ma_sv1 == sv.Ma_sv1) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(sv);
                svDA.UPdate(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
     

        // tìm kiếm
        public List<SinhVien> TimSinhVien(SinhVien sv)
        {
            List<SinhVien> list = svDA.GetAllData();
            List<SinhVien> kq = new List<SinhVien>();

            //Voi gai tri ngam dinh ban dau
            if (sv.Ten_sv1 == null && sv.Que_quan1 == null && sv.Ma_sv1 == 0)
            {
                kq = list;
            }
            //Tim theo ho ten
            if (sv.Ten_sv1 != null && sv.Que_quan1 == null && sv.Ma_sv1 == 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Ten_sv1.IndexOf(sv.Ten_sv1) >= 0)
                    {
                        kq.Add(new SinhVien(list[i]));
                    }
            }
            // Tim theo que quan
            else if (sv.Ten_sv1 == null && sv.Que_quan1 != null && sv.Ma_sv1 == 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Que_quan1.IndexOf(sv.Que_quan1) >= 0)
                    {
                        kq.Add(new SinhVien(list[i]));
                    }
            }
            //Tim theo ma
            else if (sv.Ten_sv1 == null && sv.Que_quan1 == null && sv.Ma_sv1 != 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Ma_sv1 == sv.Ma_sv1)
                    {
                        kq.Add(new SinhVien(list[i]));
                    }
            }
            //Tim ket hop giua ho ten va que quan
            else if (sv.Ten_sv1 != null && sv.Que_quan1 != null && sv.Ma_sv1 == 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Ten_sv1.IndexOf(sv.Ten_sv1) >= 0 && list[i].Que_quan1.IndexOf(sv.Que_quan1) >= 0)
                    {
                        kq.Add(new SinhVien(list[i]));
                    }
            }
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;

        }
    }
}
