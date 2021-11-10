using System;
using System.Collections.Generic;
using System.Text;
using DA1.Entities;
using DA1.DataAccess.Service_Interface;
using DA1.Business.Service_Interface;
using System.Threading;

namespace DA1.View
{
    class FormSinhVien
    {
        List<SinhVien> listsv = new List<SinhVien>();
        private ISinhVienBLL sinhvien= new SinhVienBLL();
        public int Display(List<SinhVien> listsv)
        {
            Lop lop=new Lop();
            Console.WriteLine($"Lớp:{lop.Malop1}");
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                      DANH SÁCH SINH VIÊN KHOA CÔNG NGHỆ THÔNG TIN                                                                                                                ║");
            Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════║");
            Console.WriteLine("║ MÃ   ║    HỌ TÊN    ║  NĂM SINH   ║    SĐT  ║ QUÊ    ║ CMND     ║ GIỚI TÍNH ║ DÂN TỘC║    TÔN GIÁO     ║      NĂM SINH      ║     SĐT      ║     CMND     ║     TÊN BỐ     ║    TÊN MẸ       ║");
            Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════║");
            
            int sl = listsv.Count;
            for (int i = sl - 1; i >= 0; i--)
            {
                Console.WriteLine($"{listsv[i].Ma_sv1}\t{listsv[i].Ten_sv1}\t{listsv[i].Nam_sinh1}\t{listsv[i].SDT1}\t{listsv[i].Que_quan1}\t{listsv[i].CMND1}\t{listsv[i].Gioi_tinh1}\t{listsv[i].Dan_toc1}\t{listsv[i].Ton_giao1}\t{listsv[i].Quoc_Tich1}\t{listsv[i].Masobaohiem1}\t{listsv[i].Email1}\t{listsv[i].Ten_Bo1}\t{listsv[i].Ten_me1}\t{listsv[i].Nghe_nghiep_me1}\t{listsv[i].Nghe_nghiep_bo1}\t{listsv[i].SDT_me1}\t{listsv[i].SDT_bo1}\t{listsv[i].Que_quan_me1}\t{listsv[i].Que_quan_bo1}");
            }
            return Console.CursorTop;
        }
        public void Nhapsinhvien()
        {
            do
            {
                //Hiên thị mẫu nhập

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                //Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Mã:                         ║ CMND:                             ║ SỐ Bảo hiểm:                     ║ Nghề Nghiệp bố:                ║");
                Console.WriteLine("║═════════════════════════════║═══════════════════════════════════║══════════════════════════════════║════════════════════════════════║");
                Console.WriteLine("║ Tên:                        ║ Giới Tính:                        ║ Email:                           ║ SĐT mẹ:                        ║");
                Console.WriteLine("║═════════════════════════════║═══════════════════════════════════║══════════════════════════════════║════════════════════════════════║");
                Console.WriteLine("║ Năm Sinh:                   ║ Dân Tộc:                          ║ Tên Bố:                          ║ SĐT bố:                        ║");
                Console.WriteLine("║═════════════════════════════║═══════════════════════════════════║══════════════════════════════════║════════════════════════════════║");
                Console.WriteLine("║ SĐT:                        ║ Tôn Giáo:                         ║ Tên Mẹ:                          ║ Quê quán Mẹ:                   ║");
                Console.WriteLine("║═════════════════════════════║═══════════════════════════════════║══════════════════════════════════║════════════════════════════════║");
                Console.WriteLine("║ Quê Quán :                  ║ Quốc Tịch :                       ║ Nghề Nghiệp mẹ:                  ║ Quê quán Bố :                  ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("NHẬP (ENTER + ESC) THOÁT"); Console.SetCursorPosition(5, 12);
                Console.WriteLine();

                //Hiển thị danh sách đã nhập
                //int x = 0, y = 8;
                
                int v = Display(sinhvien.GetAllData());
                SinhVien sv = new SinhVien();
                try
                {

                    Console.SetCursorPosition(5, 1); sv.Ma_sv1 = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(6, 3); sv.Ten_sv1 = Console.ReadLine();
                    Console.SetCursorPosition(12, 5); sv.Nam_sinh1 = (Console.ReadLine());
                    Console.SetCursorPosition(8, 7); sv.SDT1 = int.Parse(Console.ReadLine());     
                    Console.SetCursorPosition(12, 9); sv.Que_quan1 = Console.ReadLine();
                    Console.SetCursorPosition(37, 1); sv.CMND1 = (Console.ReadLine());
                    Console.SetCursorPosition(42, 3); sv.Gioi_tinh1 =(Console.ReadLine());                 
                    Console.SetCursorPosition(41, 5); sv.Dan_toc1 = Console.ReadLine();
                    Console.SetCursorPosition(43, 7); sv.Ton_giao1 = (Console.ReadLine());
                    Console.SetCursorPosition(44, 9); sv.Quoc_Tich1 = (Console.ReadLine());

                    Console.SetCursorPosition(80, 1); sv.Masobaohiem1 = (Console.ReadLine());
                    Console.SetCursorPosition(74, 3); sv.Email1 = (Console.ReadLine());
                    Console.SetCursorPosition(75, 5); sv.Ten_Bo1 = (Console.ReadLine());
                    Console.SetCursorPosition(75, 7); sv.Ten_me1 = (Console.ReadLine());
                    Console.SetCursorPosition(83, 9); sv.Nghe_nghiep_me1 = (Console.ReadLine());
                    Console.SetCursorPosition(118, 1); sv.Nghe_nghiep_bo1 = (Console.ReadLine());
                    Console.SetCursorPosition(110, 3); sv.SDT_me1 = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(110, 5); sv.SDT_bo1 = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(115, 7); sv.Que_quan_me1 = (Console.ReadLine());
                    Console.SetCursorPosition(115, 9); sv.Que_quan_bo1 = (Console.ReadLine());
                }
                catch (Exception)
                {


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(136, 2); Console.WriteLine(" ╔═══════════════════════════════╗");
                    Console.SetCursorPosition(136, 3); Console.WriteLine(" ║       Vui lòng nhập lại !     ║");
                    Console.SetCursorPosition(136, 4); Console.WriteLine(" ║ Thông tin bắt buộc phải nhập !║");
                    Console.SetCursorPosition(136, 5); Console.WriteLine(" ╚═══════════════════════════════╝");
                   
                }

                    Console.ResetColor();
              
                ConsoleKeyInfo kt = Console.ReadKey(true);
                if (kt.Key == ConsoleKey.Escape) return;
                else if (kt.Key == ConsoleKey.Enter)
                {
                    sinhvien.Insert(sv);
                }
                Console.ResetColor();
            } while (true);

        }
        public void XoaSV()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                ISinhVienBLL sinhvien = new SinhVienBLL();
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗"); Thread.Sleep(5);
                Console.WriteLine("║                  NHẬP ĐỐI TƯỢNG CẦN XÓA                    ║"); Thread.Sleep(7);
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝"); Thread.Sleep(19);
                Console.SetCursorPosition(1, 3);
                Console.WriteLine("╔════════════════════════════════════╗"); Thread.Sleep(5);
                Console.SetCursorPosition(1, 4);
                Console.WriteLine("║  MÃ SINH VIÊN:                     ║   ");
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("╚════════════════════════════════════╝"); Thread.Sleep(19);
                Console.SetCursorPosition(1, 6);


                Display(sinhvien.GetAllData()); Console.SetCursorPosition(18, 4);
                int masv = int.Parse("0" + Console.ReadLine());
                if (masv == 0) return;
                else sinhvien.Delete(masv);
            } while (true);
        }

        public void SuaSV()
        {
        
        }
        public void TimSV()
        {
            string ten_sv = "";
            do
            {
                Console.Clear();
                ISinhVienBLL sinhvien = new SinhVienBLL();
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗"); Thread.Sleep(5);
                Console.WriteLine("║                  NHẬP ĐỐI TƯỢNG CẦN TÌM                    ║"); Thread.Sleep(7);
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝"); Thread.Sleep(19);
                Console.SetCursorPosition(1, 3);
                Console.WriteLine("╔════════════════════════════════════╗"); Thread.Sleep(5);
                Console.SetCursorPosition(1, 4);
                Console.WriteLine("║  TÊN SINH VIÊN:                    ║   ");
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("╚════════════════════════════════════╝"); Thread.Sleep(19);
                Console.SetCursorPosition(1, 6);
                Console.WriteLine("Nhập ENTER để Thoát");
                Display(sinhvien.GetAllData()); Console.SetCursorPosition(18, 4);
                List<SinhVien> list = sinhvien.TimSinhVien(new SinhVien());
                ten_sv = Console.ReadLine();
                if (ten_sv == "") return;
            } while (true);
        }
    }
}
