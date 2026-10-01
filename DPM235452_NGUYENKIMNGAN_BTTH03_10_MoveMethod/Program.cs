using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_10_MoveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 10: MOVE METHOD ===");

            // 1. BEFORE
            Before before = new Before { DaysOverdrawn = 10 };
            before.Type.IsPremium = true;
            Console.WriteLine($"[BEFORE] Phí ngân hàng: ${before.BankCharge():F2}");

            // 2. AFTER
            After after = new After { DaysOverdrawn = 10 };
            after.Type.IsPremium = true;
            Console.WriteLine($"[AFTER] Phí ngân hàng: ${after.BankCharge():F2}");

            // 3. REAL
            AccountTypeReal typeReal = new AccountTypeReal(true);
            Real real = new Real(typeReal, 10);
            Console.WriteLine($"[REAL] Phí ngân hàng chuẩn: ${real.CalculateBankCharge():F2}");

            Console.ReadLine();
        }
    }
}