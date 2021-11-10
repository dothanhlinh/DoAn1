using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA1.View;
using System.Threading;
using DA1.Entities;

namespace DA1.View
{
    class MenuSinhVien
    {
        FormSinhVien sv = new FormSinhVien();
        public void menusv()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                //Console.BackgroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(32, 8);
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗"); Thread.Sleep(5);
                Console.SetCursorPosition(32, 9);
                Console.WriteLine("║              ______QUẢN LÝ SINH VIÊN______                 ║"); Thread.Sleep(6);
                Console.SetCursorPosition(32, 10);
                Console.WriteLine("║════════════════════════════════════════════════════════════║"); Thread.Sleep(7);
                Console.SetCursorPosition(32, 11);
                Console.WriteLine("║                 1.Nhập thêm thông tin sinh viên            ║"); Thread.Sleep(8);
                Console.SetCursorPosition(32, 12);
                Console.WriteLine("║════════════════════════════════════════════════════════════║"); Thread.Sleep(9);
                Console.SetCursorPosition(32, 13);
                Console.WriteLine("║                 2.Sửa thông tin sinh viên                  ║"); Thread.Sleep(10);
                Console.SetCursorPosition(32, 14);
                Console.WriteLine("║════════════════════════════════════════════════════════════║"); Thread.Sleep(11);
                Console.SetCursorPosition(32, 15);
                Console.WriteLine("║                 3.Xóa thông tin sinh viên                  ║"); Thread.Sleep(12);
                Console.SetCursorPosition(32, 16);
                Console.WriteLine("║════════════════════════════════════════════════════════════║"); Thread.Sleep(13);
                Console.SetCursorPosition(32, 17);
                Console.WriteLine("║                 4.Tìm kiếm thông tin sinh viên             ║"); Thread.Sleep(14);
                Console.SetCursorPosition(32, 18);
                Console.WriteLine("║════════════════════════════════════════════════════════════║"); Thread.Sleep(15);
                Console.SetCursorPosition(32, 19);
                Console.WriteLine("║                 5.Hiển Thị                                 ║"); Thread.Sleep(16);
                Console.SetCursorPosition(32, 20);
                Console.WriteLine("║════════════════════════════════════════════════════════════║"); Thread.Sleep(17);
                Console.SetCursorPosition(32, 21);
                Console.WriteLine("║                 6.Thoát                                    ║"); Thread.Sleep(18);
                Console.SetCursorPosition(32, 22);
                Console.WriteLine("║════════════════════════════════════════════════════════════║"); Thread.Sleep(15);
                Console.SetCursorPosition(32, 23);
                Console.WriteLine("║                 7.Quay Lại                                 ║"); Thread.Sleep(16);
                Console.SetCursorPosition(32, 24);
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝"); Thread.Sleep(19);
                Console.SetCursorPosition(32, 25);


                Console.SetCursorPosition(33, 25);
                Console.WriteLine("Chọn từ 1-6 :"); 
                Console.SetCursorPosition(47, 25);
                Console.ResetColor();
                int ktrasv;
                do
                {
                    ktrasv = int.Parse(Console.ReadLine());

                    switch (ktrasv)
                    {
                        case 1:
                            Console.Clear();
                            sv.Nhapsinhvien();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            
                            break;
                        case 3:
                            Console.Clear();
                            sv.XoaSV();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            sv.TimSV();
                            Console.Clear();
                            break;
                        case 5:
                            //sv.Display(listsv);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        case 7:
                            Console.Clear();
                            break;


                    }
                } while (ktrasv < 1 || ktrasv > 7);
                if (ktrasv == 7)
                {
                    break;
                }
            }
        }
    }
}
