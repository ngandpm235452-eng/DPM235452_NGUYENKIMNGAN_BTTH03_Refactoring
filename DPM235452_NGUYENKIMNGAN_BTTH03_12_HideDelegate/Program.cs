using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_12_HideDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 12: HIDE DELEGATE ===");

            // 1. BEFORE (Client phải gọi lồng qua thuộc tính Department)
            Before before = new Before();
            Console.WriteLine($"[BEFORE] {before.Name} - Quản lý: {before.Department.Manager}");

            // 2. AFTER (Client gọi hàm trực tiếp từ Person)
            After after = new After();
            Console.WriteLine($"[AFTER] {after.Name} - Quản lý: {after.GetManager()}");

            // 3. REAL (An toàn null, đóng gói tốt)
            DepartmentReal dept = new DepartmentReal("Phòng CNTT", "Phan Văn B");
            Real real = new Real("Nguyen Kim Ngan", dept);
            Console.WriteLine($"[REAL] Nhân viên: {real.EmployeeName} | {real.DepartmentInfo}");

            Console.ReadLine();
        }
    }
}