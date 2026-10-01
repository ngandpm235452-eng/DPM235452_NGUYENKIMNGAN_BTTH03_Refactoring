using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_11_MoveField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 11: MOVE FIELD ===");
            double amount = 10_000_000;

            // 1. BEFORE
            Before before = new Before();
            Console.WriteLine($"[BEFORE] Tiền lãi: {before.CalculateInterest(amount):N0} VNĐ");

            // 2. AFTER
            After after = new After();
            Console.WriteLine($"[AFTER] Tiền lãi: {after.CalculateInterest(amount):N0} VNĐ");

            // 3. REAL
            AccountTypeReal typeReal = new AccountTypeReal("Tiết kiệm", 0.05);
            Real real = new Real(typeReal);
            Console.WriteLine($"[REAL] Tiền lãi chuẩn: {real.CalculateInterest(amount):N0} VNĐ");

            Console.ReadLine();
        }
    }
}