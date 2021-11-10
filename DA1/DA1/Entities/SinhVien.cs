using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA1.Entities
{
    class SinhVien
    {
        #region Các trường dữ liệu
        private int Ma_sv;
        private string Ten_sv;
        private string Nam_sinh;
        private int SDT;
        private string Que_quan;
        private string CMND;
        private string Gioi_tinh;
        private string Dan_toc;
        private string Ton_giao;
        private string Quoc_Tich;
        private string Masobaohiem;
        private string Email;
        private string Ten_Bo;
        private string Ten_me;
        private string Nghe_nghiep_me;
        private string Nghe_nghiep_bo;
        private int SDT_me;
        private int SDT_bo;
        private string Que_quan_me;
        private string Que_quan_bo;
        #endregion

        #region Các phương thức khởi tạo
        public SinhVien() {}

        public SinhVien(SinhVien sv)
        {
            Ma_sv = sv.Ma_sv;
            Ten_sv = string.Copy(sv.Ten_sv);
            Nam_sinh = sv.Nam_sinh;
            SDT = sv.SDT;
            Que_quan = string.Copy(sv.Que_quan);
            CMND = sv.CMND;
            Gioi_tinh = sv.Gioi_tinh;
            Dan_toc = sv.Dan_toc;
            Ton_giao = sv.Ton_giao;
            Quoc_Tich = sv.Quoc_Tich;
            Masobaohiem = sv.Masobaohiem;
            Email = sv.Email;
            Ten_Bo = sv.Ten_Bo;
            Ten_me = sv.Ten_me;
            Nghe_nghiep_me = sv.Nghe_nghiep_me;
            Nghe_nghiep_bo = sv.Nghe_nghiep_bo;
            SDT_me = sv.SDT_me;
            SDT_bo = sv.SDT_bo;
            Que_quan_me = sv.Que_quan_me;
            Que_quan_bo = sv.Que_quan_bo;
        }

        public SinhVien(int ma_sv, string ten_sv, string nam_sinh, int sDT, string que_quan, string cMND, string gioi_tinh, string dan_toc, string ton_giao, string quoc_Tich, string masobaohiem, string email, string ten_Bo, string ten_me, string nghe_nghiep_me, string nghe_nghiep_bo, int sDT_me, int sDT_bo, string que_quan_me, string que_quan_bo)
        {
            Ma_sv = ma_sv;
            Ten_sv = ten_sv;
            Nam_sinh = nam_sinh;
            SDT = sDT;
            Que_quan = que_quan;
            CMND = cMND;
            Gioi_tinh = gioi_tinh;
            Dan_toc = dan_toc;
            Ton_giao = ton_giao;
            Quoc_Tich = quoc_Tich;
            Masobaohiem = masobaohiem;
            Email = email;
            Ten_Bo = ten_Bo;
            Ten_me = ten_me;
            Nghe_nghiep_me = nghe_nghiep_me;
            Nghe_nghiep_bo = nghe_nghiep_bo;
            SDT_me = sDT_me;
            SDT_bo = sDT_bo;
            Que_quan_me = que_quan_me;
            Que_quan_bo = que_quan_bo;
        }

        #endregion

        #region Thuộc tính 
        public int Ma_sv1 { get => Ma_sv; set => Ma_sv = value; }
        public string Ten_sv1 { get => Ten_sv; set => Ten_sv = value; }
        public string Nam_sinh1 { get => Nam_sinh; set => Nam_sinh = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string Que_quan1 { get => Que_quan; set => Que_quan = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string Gioi_tinh1 { get => Gioi_tinh; set => Gioi_tinh = value; }
        public string Dan_toc1 { get => Dan_toc; set => Dan_toc = value; }
        public string Ton_giao1 { get => Ton_giao; set => Ton_giao = value; }
        public string Quoc_Tich1 { get => Quoc_Tich; set => Quoc_Tich = value; }
        public string Masobaohiem1 { get => Masobaohiem; set => Masobaohiem = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Ten_Bo1 { get => Ten_Bo; set => Ten_Bo = value; }
        public string Ten_me1 { get => Ten_me; set => Ten_me = value; }
        public string Nghe_nghiep_me1 { get => Nghe_nghiep_me; set => Nghe_nghiep_me = value; }
        public string Nghe_nghiep_bo1 { get => Nghe_nghiep_bo; set => Nghe_nghiep_bo = value; }
        public int SDT_me1 { get => SDT_me; set => SDT_me = value; }
        public int SDT_bo1 { get => SDT_bo; set => SDT_bo = value; }
        public string Que_quan_me1 { get => Que_quan_me; set => Que_quan_me = value; }
        public string Que_quan_bo1 { get => Que_quan_bo; set => Que_quan_bo = value; }

        #endregion
    }
}
