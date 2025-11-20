using System;

namespace Bai6_SumiHoiThoai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 6: CHUONG TRINH SUMI NOI CHUYEN VOI NGUOI DUNG ===\n");

            Console.WriteLine("Xin chao! Toi la sumi. Chung ta cung noi chuyen nhe. ^_^");

            Console.Write("Ten cua ban la gi? ");
            string ten = Console.ReadLine();

            Console.Write("Ban bao nhieu tuoi? ");
            string tuoi = Console.ReadLine();

            Console.Write("Gioi tinh cua ban (Nam/Nu/Khac): ");
            string gioiTinh = Console.ReadLine();

            Console.Write("So dien thoai: ");
            string sdt = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Dia chi hien tai: ");
            string diaChi = Console.ReadLine();

            Console.Write("Nghe nghiep: ");
            string nghe = Console.ReadLine();

            Console.Write("So thich cua ban: ");
            string soThich = Console.ReadLine();

            Console.Write("So truong cua ban (ban gioi nhat ve dieu gi?): ");
            string soTruong = Console.ReadLine();

            Console.Write("Ban muon chia se them thong tin gi khac khong? ");
            string thongTinKhac = Console.ReadLine();

            Console.WriteLine("\n--- TONG KET CUOC NOI CHUYEN ---");
            Console.WriteLine($"Xin chao {ten}, {tuoi} tuoi, gioi tinh {gioiTinh}.");
            Console.WriteLine($"Ban dang song o {diaChi}, lam nghe {nghe}.");
            Console.WriteLine($"So dien thoai: {sdt}, Email: {email}.");
            Console.WriteLine($"So thich cua ban: {soThich}.");
            Console.WriteLine($"So truong cua ban: {soTruong}.");
            Console.WriteLine($"Thong tin khac: {thongTinKhac}");

            Console.WriteLine("\nRat vui duoc noi chuyen voi ban! ^_^");
            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
