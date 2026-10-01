using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_01_ExtractMethod
{
    public class Final
    {
        private readonly string _customerName;
        private readonly double _amount;

        // Đóng gói dữ liệu qua Constructor và kiểm tra hợp lệ
        public Final(string customerName, double amount)
        {
            _customerName = string.IsNullOrWhiteSpace(customerName) ? "Unknown" : customerName;
            _amount = amount >= 0 ? amount : 0;
        }

        public void PrintOwing()
        {
            PrintBanner();
            PrintDetails();
        }

        private static void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private void PrintDetails()
        {
            Console.WriteLine($"Customer Name: {_customerName}");
            Console.WriteLine($"Amount Due   : {_amount:C2}");
        }
    }
}