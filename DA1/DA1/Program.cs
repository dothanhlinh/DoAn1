using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DA1.View;
namespace DA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuVatlieu vl = new MenuVatlieu();
            //MenuNCC ncc = new MenuNCC();
            //menuNV nv = new menuNV();
            //MenuKH kh = new MenuKH();
            //MenuHD hd = new MenuHD();
            //MenuCongno cn = new MenuCongno();
            MenuSinhVien sv = new MenuSinhVien();
            MenuLop lop = new MenuLop();

            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                int check;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("╔═══════════════════════════════════════════════════╗"); Thread.Sleep(5);
                    Console.SetCursorPosition(35, 11);
                    Console.WriteLine("║             QUẢN LÝ LÝ LỊCH SINH VIÊN             ║"); Thread.Sleep(6);
                    Console.SetCursorPosition(35, 12);
                    Console.WriteLine("║═══════════════════════════════════════════════════║"); Thread.Sleep(7);
                    Console.SetCursorPosition(35, 13);
                    Console.WriteLine("║                 1.Quản lý sinh viên               ║"); Thread.Sleep(8);
                    Console.SetCursorPosition(35, 14);
                    Console.WriteLine("║═══════════════════════════════════════════════════║"); Thread.Sleep(9);
                    Console.SetCursorPosition(35, 15);
                    Console.WriteLine("║                 2.Quản lý lớp học                 ║"); Thread.Sleep(10);
                    Console.SetCursorPosition(35, 16);
                    Console.WriteLine("║═══════════════════════════════════════════════════║"); Thread.Sleep(11);
                    Console.SetCursorPosition(35, 17);
                    Console.WriteLine("║                 3.Quản lý ngành                   ║"); Thread.Sleep(12);
                    Console.SetCursorPosition(35, 18);
                    Console.WriteLine("║═══════════════════════════════════════════════════║"); Thread.Sleep(11);
                    Console.SetCursorPosition(35, 19);
                    Console.WriteLine("║                 4.Quản lý Khoa                    ║"); Thread.Sleep(12);
                    Console.SetCursorPosition(35, 20);
                    Console.WriteLine("║═══════════════════════════════════════════════════║"); Thread.Sleep(11);
                    Console.SetCursorPosition(35, 21);
                    Console.WriteLine("║                 5.Thoát                           ║"); Thread.Sleep(12);
                    Console.SetCursorPosition(35, 22);
                    Console.WriteLine("╚═══════════════════════════════════════════════════╝"); Thread.Sleep(13);
                    Console.SetCursorPosition(35, 23);
                    Console.WriteLine("Chọn từ 1-3 :");
                    Console.SetCursorPosition(48, 23);
                    check = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (check)
                    {
                        case 1:
                            sv.menusv();
                            break;
                        case 2:
                            lop.menulop();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                    }
                } while (check < 1 || check > 5);
            }

        }
    }
}
