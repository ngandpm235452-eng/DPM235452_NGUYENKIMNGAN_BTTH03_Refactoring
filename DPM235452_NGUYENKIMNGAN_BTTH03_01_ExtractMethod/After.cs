using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_01_ExtractMethod
{
    public class After
    {
        // Tách các đoạn code có chức năng riêng thành phương thức độc lập
        public void PrintOwing(string name, double amount)
        {
            PrintBanner();
            PrintDetails(name, amount);
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private void PrintDetails(string name, double amount)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}");
        }
    }
}