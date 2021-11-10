using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DA1.Entities;
using DA1.DataAccess.Service_Interface;

namespace DA1.DataAccess
{
    class LopDAL:ILopDAL
    {
        private string txtfile = "Data/lop.txt";


        //public List<Lop> GetAllData()
        //{
        //    List<Lop> dslop = new List<Lop>();
        //    if (File.Exists(txtfile))
        //    { dslop = null; }
        //    else
        //    {
        //        StreamReader r = new StreamReader(txtfile);
        //        string sl;
        //        while ((sl = r.ReadLine()) != null)
        //        {
        //            string[] l = sl.Split('#');
        //            Lop lo = new Lop();
        //            lo.Malop1 = int.Parse(l[0]);
        //            lo.Tenlop1 = l[1];
                    
        //            dslop.Add(lo);
        //        }
        //        r.Close();
        //    }
        //    return dslop;
        //}
        public List<Lop> GetAllData()
        {
            List<Lop> listlop = new List<Lop>();
            StreamReader myFile = File.OpenText(txtfile);
            string temp;
            while ((temp = myFile.ReadLine()) != null)
            {
                if (temp.Trim() != "")
                {
                    string[] l = temp.Split('#');
                    listlop.Add(new Lop(int.Parse(l[0]), l[1]));
                }
            }
            myFile.Close();
            return listlop;
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
        public void Insert(Lop lop)
        {
            int masv = GetMaSV() + 1;
            StreamWriter sw = File.AppendText(txtfile);
            sw.WriteLine();
            sw.Write(lop.Malop1 + "#" + lop.Tenlop1 );
            sw.Close();
        }
        //Xóa đi một lớp 
        public void Delete(int malop)
        {
            List<Lop> listlop = GetAllData();
            StreamWriter sw = File.CreateText(txtfile);
            foreach (Lop l in listlop)
            {
                if (l.Malop1 != malop)
                {
                    sw.Write(l.Malop1 + "#" + l.Tenlop1);
                }
                sw.Close();
            }
        }
        // Sửa một lớp 
        public void UPdate(List<Lop> listlop)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < listlop.Count; ++i)
                fwrite.WriteLine(listlop[i].Malop1 + "#" + listlop[i].Tenlop1);
            fwrite.Close();
        }
    }
}
