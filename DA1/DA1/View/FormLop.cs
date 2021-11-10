using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA1.Entities;
using DA1.DataAccess.Service_Interface;
using DA1.Business.Service_Interface;
using DA1.Business;
using System.Threading;
namespace DA1.View
{
    class FormLop
    {
        List<Lop> listsv = new List<Lop>();
        private ILopBLL lop = new LopBLL();
        public int Display(List<Lop> listlop)
        {
            Console.WriteLine();
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║           THÔNG TIN VỀ LỚP                  ║");
            Console.WriteLine("║═════════════════════════════════════════════║");
            Console.WriteLine("║ MÃ LỚP:           ║  TÊN LỚP:               ║");
            Console.WriteLine("║═════════════════════════════════════════════║");

            int sl = listlop.Count;
            for (int i = sl - 1; i >= 0; i--)
            {
                Console.WriteLine($"   {listlop[i].Malop1}\t\t\t{listlop[i].Tenlop1}");
            }
            return Console.CursorTop;
        }
        public void Nhaplop()
        {
            do
            {
                //Hiên thị mẫu nhập

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                //Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════╗");
                Console.WriteLine("║ Mã Lớp:                     ║");
                Console.WriteLine("║═════════════════════════════║");
                Console.WriteLine("║ Tên Lớp:                    ║");
                Console.WriteLine("╚═════════════════════════════╝");
                Console.WriteLine("NHẬP (ENTER + ESC) THOÁT"); 
                int v = Display(lop.GetAllData());
                Console.WriteLine();
   
                //Hiển thị danh sách đã nhập
                Lop l = new Lop();
                try
                {

                    Console.SetCursorPosition(9, 1); l.Malop1 = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(10, 3); l.Tenlop1 = Console.ReadLine();

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
                    lop.Insert(l);
                }
                Console.ResetColor();
            } while (true);

        }
        public void Xoalop()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                ILopBLL l = new LopBLL();
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
                Display(lop.GetAllData()); Console.SetCursorPosition(18, 4);
                int malop = int.Parse("0" + Console.ReadLine());
                Console.WriteLine("Đã xóa thành công!");
                if (malop == 0) return;
                else l.Delete(malop);
            } while (true);
        }

        public void Sualop()
        {

        }
        public void Timlop()
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
                List<SinhVien> list = sinhvien.TimSinhVien(new SinhVien());
                Display(lop.GetAllData()); Console.SetCursorPosition(18, 4);
                ten_sv = Console.ReadLine();
                if (ten_sv == "") return;
            } while (true);
        }
    }
}

