using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_03_DecomposeConditional
{
    public class After
    {
        // Tách điều kiện và hành động trong các nhánh if-else thành các phương thức riêng
        public double CalculateTicketPrice(DateTime date, int quantity, double basePrice)
        {
            if (IsSummer(date))
            {
                return SummerCharge(quantity, basePrice);
            }
            else
            {
                return RegularCharge(quantity, basePrice);
            }
        }

        private bool IsSummer(DateTime date) => date.Month >= 6 && date.Month <= 8;
        private double SummerCharge(int quantity, double basePrice) => quantity * basePrice * 1.5;
        private double RegularCharge(int quantity, double basePrice) => quantity * basePrice;
    }
}