using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_13_RemoveMiddleMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 13: REMOVE MIDDLE MAN ===");

            // 1. BEFORE (Client gọi qua hàm trung gian)
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Quản lý (qua Middle Man): {before.GetManager()}");

            // 2. AFTER (Client gọi trực tiếp tới thuộc tính phòng ban)
            After after = new After();
            Console.WriteLine($"[AFTER] Quản lý (truy cập trực tiếp): {after.Department.Manager}");

            // 3. REAL (Cấu trúc ứng dụng thực tế)
            DepartmentReal dept = new DepartmentReal("Phòng Kinh Doanh", "Tran Van B");
            Real real = new Real("Nguyen Kim Ngan", dept);
            Console.WriteLine($"[REAL] Nhân viên: {real.EmployeeName} | {real.Department.Name} (Quản lý: {real.Department.Manager})");

            Console.ReadLine();
        }
    }
}