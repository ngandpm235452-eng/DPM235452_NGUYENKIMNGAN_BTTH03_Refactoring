using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_14_InlineClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 14: INLINE CLASS ===");

            // 1. BEFORE (Truy cập qua lớp TelephoneNumber dư thừa)
            Before before = new Before();
            Console.WriteLine($"[BEFORE] {before.Name} - SĐT: {before.GetFullPhone()}");

            // 2. AFTER (Đã gộp lớp TelephoneNumber vào trực tiếp lớp After)
            After after = new After();
            Console.WriteLine($"[AFTER] {after.Name} - SĐT: {after.GetFullPhone()}");

            // 3. REAL (Khởi tạo chuẩn hóa với Constructor & Read-only)
            Real real = new Real("Nguyen Kim Ngan", "028", "12345678");
            Console.WriteLine($"[REAL] {real.Name} - SĐT chuẩn: {real.FullPhone}");

            Console.ReadLine();
        }
    }
}