using System;

namespace DPM235452_NGUYENKIMNGAN_BTH03_01_ExtractMethod
{
    public class After
    {
        public void PrintOwing(string name, double amount)
        {
            PrintBanner();
            PrintDetails(name, amount);
        }

        private void PrintBanner()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("**** Customer *****");
            Console.WriteLine("*******************");
        }

        private void PrintDetails(string name, double amount)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}");
        }
    }
}