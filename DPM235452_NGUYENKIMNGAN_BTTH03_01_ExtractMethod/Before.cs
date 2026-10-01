using System;

namespace DPM235452_NGUYENKIMNGAN_BTH03_01_ExtractMethod
{
    public class Before
    {
        public void PrintOwing(string name, double amount)
        {
            // In ra banner
            Console.WriteLine("*******************");
            Console.WriteLine("**** Customer *****");
            Console.WriteLine("*******************");

            // In ra chi tiết hóa đơn
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}");
        }
    }
}