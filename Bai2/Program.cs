using System;

namespace Bai2_MenuF1F7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2: HIEN THI MENU ===\n");

            Console.WriteLine("F1: Nhap            F5: Tim kiem theo ten");
            Console.WriteLine("F2: Nhap them       F6: Hien thi hoc sinh gioi");
            Console.WriteLine("F3: Doc tep         F7: Thong ke");
            Console.WriteLine("F4: Hien thi        ESC: Thoat");

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
