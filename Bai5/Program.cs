using System;

namespace Bai5_TaiKhoanMatKhau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 5: NHAP TAI KHOAN VA MAT KHAU ===\n");

            Console.Write("Tai khoan: ");
            string taiKhoan = Console.ReadLine();

            Console.Write("Mat khau : ");
            string matKhau = Console.ReadLine(); // bản đơn giản

            Console.WriteLine("\nBan da nhap:");
            Console.WriteLine($"- Tai khoan: {taiKhoan}");
            Console.WriteLine($"- Mat khau : {matKhau}");

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
