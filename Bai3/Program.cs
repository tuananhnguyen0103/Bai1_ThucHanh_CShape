using System;

namespace Bai3_MayTinhMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 3: MAY TINH DON GIAN (Math) ===\n");

            Console.Write("Nhap so thu nhat: ");
            double a = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("\nChon phep tinh:");
            Console.WriteLine("1. Cong (a + b)");
            Console.WriteLine("2. Tru (a - b)");
            Console.WriteLine("3. Nhan (a * b)");
            Console.WriteLine("4. Chia (a / b)");
            Console.WriteLine("5. Luy thua (a^b) - Math.Pow");
            Console.WriteLine("6. Can bac hai cua a - Math.Sqrt");
            Console.Write("Lua chon (1-6): ");

            string choice = Console.ReadLine();
            double result;

            Console.WriteLine(); // dòng trống

            switch (choice)
            {
                case "1":
                    result = a + b;
                    Console.WriteLine($"Ket qua: {a} + {b} = {result}");
                    break;
                case "2":
                    result = a - b;
                    Console.WriteLine($"Ket qua: {a} - {b} = {result}");
                    break;
                case "3":
                    result = a * b;
                    Console.WriteLine($"Ket qua: {a} * {b} = {result}");
                    break;
                case "4":
                    if (b == 0)
                    {
                        Console.WriteLine("Khong the chia cho 0!");
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine($"Ket qua: {a} / {b} = {result}");
                    }
                    break;
                case "5":
                    result = Math.Pow(a, b);
                    Console.WriteLine($"Ket qua: {a}^{b} = {result}");
                    break;
                case "6":
                    if (a < 0)
                    {
                        Console.WriteLine("Khong the lay can bac hai so am!");
                    }
                    else
                    {
                        result = Math.Sqrt(a);
                        Console.WriteLine($"Ket qua: sqrt({a}) = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
