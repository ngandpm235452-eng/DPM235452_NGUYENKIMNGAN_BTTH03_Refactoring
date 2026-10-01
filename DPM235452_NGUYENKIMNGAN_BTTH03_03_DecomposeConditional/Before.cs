using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_03_DecomposeConditional
{
    public class Before
    {
        // Code Smell: Khối if-else kiểm tra điều kiện quá phức tạp, khó đọc
        public double CalculateTicketPrice(DateTime date, int quantity, double basePrice)
        {
            double charge;
            if (date.Month >= 6 && date.Month <= 8) // Điều kiện mùa hè
            {
                charge = quantity * basePrice * 1.5; // Mùa hè nhân hệ số 1.5
            }
            else
            {
                charge = quantity * basePrice;
            }
            return charge;
        }
    }
}