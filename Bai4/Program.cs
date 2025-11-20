using System;

namespace Bai4_GioiThieuBanThan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 4: GIOI THIEU BAN THAN ===\n");

            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            string tuoi = Console.ReadLine();

            Console.Write("Nhap ngay sinh (VD: 01/01/2000): ");
            string ngaySinh = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();

            Console.Write("Nhap nghe nghiep: ");
            string ngheNghiep = Console.ReadLine();

            Console.Write("Nhap so thich: ");
            string soThich = Console.ReadLine();

            Console.Write("Nhap so truong (diem manh): ");
            string soTruong = Console.ReadLine();

            Console.WriteLine("\n--- THONG TIN GIOI THIEU ---");
            Console.WriteLine($"Ten        : {ten}");
            Console.WriteLine($"Tuoi       : {tuoi}");
            Console.WriteLine($"Ngay sinh  : {ngaySinh}");
            Console.WriteLine($"Dia chi    : {diaChi}");
            Console.WriteLine($"Nghe nghiep: {ngheNghiep}");
            Console.WriteLine($"So thich   : {soThich}");
            Console.WriteLine($"So truong  : {soTruong}");

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
