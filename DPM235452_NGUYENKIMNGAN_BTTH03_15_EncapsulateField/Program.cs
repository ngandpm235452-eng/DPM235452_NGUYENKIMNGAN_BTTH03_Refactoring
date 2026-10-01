using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_15_EncapsulateField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 15: ENCAPSULATE FIELD ===");

            // 1. BEFORE (Gán biến public trực tiếp)
            Before before = new Before();
            before.Name = "Nguyen Kim Ngan";
            Console.WriteLine($"[BEFORE] Tên: {before.Name}");

            // 2. AFTER (Sử dụng Getter / Setter)
            After after = new After();
            after.SetName("Nguyen Kim Ngan");
            Console.WriteLine($"[AFTER] Tên: {after.GetName()}");

            // 3. REAL (Auto-Property, private set & Validate)
            Real real = new Real("Nguyen Kim Ngan");
            Console.WriteLine($"[REAL] Tên chuẩn hóa: {real.Name}");

            Console.ReadLine();
        }
    }
}