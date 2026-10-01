using System;

namespace DPM235452_NGUYENKIMNGAN_BTH03_01_ExtractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TRƯỚC KHI REFACTORING (BEFORE) ===");
            Before before = new Before();
            before.PrintOwing("Nguyen Kim Ngan", 500.50);

            Console.WriteLine("\n=== SAU KHI REFACTORING (AFTER) ===");
            After after = new After();
            after.PrintOwing("Nguyen Kim Ngan", 500.50);
        }
    }
}