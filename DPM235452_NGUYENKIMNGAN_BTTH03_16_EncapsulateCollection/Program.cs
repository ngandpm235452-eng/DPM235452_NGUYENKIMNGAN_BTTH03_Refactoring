using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_16_EncapsulateCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 16: ENCAPSULATE COLLECTION ===");

            // 1. BEFORE (Bên ngoài can thiệp làm rỗng danh sách bất ngờ)
            Before before = new Before();
            before.Courses.Add(new Course("Refactoring OO"));
            before.Courses.Clear(); // Nguy cơ vô tình xóa sạch dữ liệu
            Console.WriteLine($"[BEFORE] Số khóa học: {before.Courses.Count}");

            // 2. AFTER (An toàn qua IReadOnlyList và phương thức AddCourse)
            After after = new After();
            after.AddCourse(new Course("Refactoring OO"));
            after.AddCourse(new Course("Design Patterns"));
            Console.WriteLine($"[AFTER] Số khóa học: {after.Courses.Count}");

            // 3. REAL (Thêm kiểm tra trùng lặp và bảo vệ toàn vẹn dữ liệu)
            Real real = new Real();
            real.AddCourse(new Course("Refactoring OO"));
            real.AddCourse(new Course("Clean Code"));
            Console.WriteLine($"[REAL] Số khóa học chuẩn: {real.Courses.Count}");

            Console.ReadLine();
        }
    }
}