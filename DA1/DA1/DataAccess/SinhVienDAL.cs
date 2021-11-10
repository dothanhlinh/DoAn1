using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using DA1.Entities;
using DA1.DataAccess.Service_Interface;

namespace DA1.DataAccess
{
    class SinhVienDAL:ISinhVienDAL
    {
        private string txtfile = "Data/sinhvien.txt";
        // kiểm tra mã sinh viên 


        //public List<SinhVien> GetAllData()
        //{
        //    List<SinhVien> listsv = new List<SinhVien>();
        //    StreamReader myFile = File.OpenText(txtfile);
        //    string temp;
        //    while ((temp = myFile.ReadLine()) != null)
        //    {
        //        if (temp.Trim() != "")
        //        {
        //            string[] l = temp.Split('#');
        //            listsv.Add(new SinhVien(int.Parse(l[0]), l[1], l[2], int.Parse(l[3]), l[4], l[5], l[6], l[7], l[8], l[9], l[10], l[11], l[12], l[13], l[14], l[15], int.Parse(l[16]), int.Parse(l[17]), l[18], l[19]));
        //        }
        //    }
        //    myFile.Close();
        //    return listsv;
        //}
        public List<SinhVien> GetAllData()
        {
            List<SinhVien> listsv = new List<SinhVien>();
            StreamReader r = File.OpenText(txtfile);
            string sl = r.ReadLine();
            while (sl != null)
            {
                if (!string.IsNullOrEmpty(sl))
                {

                    sl.Trim();
                    sl = DA1.Utility.CongCu.CatXau(sl);
                    string[] l = sl.Split('#');
           
                    listsv.Add(new SinhVien(int.Parse(l[0]), l[1], l[2], int.Parse(l[3]), l[4], l[5], l[6], l[7], l[8], l[9], l[10], l[11], l[12], l[13], l[14], l[15], int.Parse(l[16]), int.Parse(l[17]), l[18], l[19]));
                }
                sl = r.ReadLine();
            }
            r.Close();
            return listsv;
        }
        public int GetMaSV()
        {
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            string tmp = "";
            while (s != null)
            {
                if (s != "") tmp = s;
                s = fread.ReadLine();
            }
            fread.Close();
            if (tmp == "") return 0;
            else
            {
                tmp = DA1.Utility.CongCu.ChuanHoaXau(tmp);
                string[] a = tmp.Split('#');
                return int.Parse(a[0]);
            }
        }
        public void Insert(SinhVien sv)
        {
            int masv = GetMaSV()+1;
            StreamWriter sw = File.AppendText(txtfile);
            sw.WriteLine();
            sw.Write(sv.Ma_sv1 + "#" + sv.Ten_sv1 + "#" + sv.Nam_sinh1 + "#" + sv.SDT1 + "#" + sv.Que_quan1 + "#" + sv.CMND1 + "#" + sv.Gioi_tinh1 + "#" + sv.Dan_toc1 +"#"+ sv.Ton_giao1 + "#" + sv.Quoc_Tich1 + "#" + sv.Masobaohiem1 + "#" + sv.Email1 + "#" + sv.Ten_Bo1 + "#" + sv.Ten_me1 + "#" + sv.Nghe_nghiep_me1 + "#"+ sv.Nghe_nghiep_bo1 + "#" + sv.SDT_me1 + "#" + sv.SDT_bo1 + "#" + sv.Que_quan_me1 + "#" + "#" + sv.Que_quan_bo1);
            sw.Close();
        }
        //Xóa đi một sinh viên 
        public void Delete(int masv)
        {
            List<SinhVien> listsv = GetAllData();
            StreamWriter sw = File.CreateText(txtfile);
            foreach (SinhVien sv in listsv)
            {
                if (sv.Ma_sv1 != masv)
                {
                    sw.Write(sv.Ma_sv1 + "#" + sv.Ten_sv1 + "#" + sv.Nam_sinh1 + "#" + sv.SDT1 + "#" + sv.Que_quan1 + "#" + sv.CMND1 + "#" + sv.Gioi_tinh1 + "#" + sv.Dan_toc1 + "#" + sv.Ton_giao1 + "#" + sv.Quoc_Tich1 + "#" + sv.Masobaohiem1 + "#" + sv.Email1 + "#" + sv.Ten_Bo1 + "#" + sv.Ten_me1 + "#" + sv.Nghe_nghiep_me1 + "#" + sv.Nghe_nghiep_bo1 + "#" + sv.SDT_me1 + "#" + sv.SDT_bo1 + "#" + sv.Que_quan_me1 + "#" + "#" + sv.Que_quan_bo1);
                }
                sw.Close();
            }
        }

        // Sửa một sinh viên 
        public void UPdate(List<SinhVien> listsv)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i <listsv.Count;++i )
                fwrite.WriteLine(listsv[i].Ma_sv1 + "#" + listsv[i].Ten_sv1 + "#" + listsv[i]. Nam_sinh1+ "#" + listsv[i].Que_quan1 + "#" + listsv[i].SDT1 + "#" + listsv[i].CMND1 + "#" +
                    listsv[i].Ten_Bo1 + "#" + listsv[i].Ten_me1 + "#" + listsv[i].Gioi_tinh1 + "#" + listsv[i].Dan_toc1 + "#" + listsv[i].Ton_giao1 + "#" + 
                    listsv[i].Quoc_Tich1 + "#" + listsv[i].Masobaohiem1 + "#" + listsv[i].Email1 + "#" + listsv[i].Nghe_nghiep_bo1 + "#" + listsv[i].Nghe_nghiep_me1 + "#" +
                    listsv[i].SDT_bo1 + "#" + listsv[i].SDT_me1 + "#" + listsv[i].Que_quan_bo1 + "#" + listsv[i].Nghe_nghiep_me1 );
            fwrite.Close();
        }
    }
}
