using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_04_ReplaceMagicNumber
{
    public class After
    {
        // Tái cấu trúc: Khai báo các hằng số có tên gọi rõ ràng đại diện cho Magic Numbers
        private const double DISCOUNT_THRESHOLD = 1000000;
        private const double DISCOUNT_RATE = 0.10; // Giảm giá 10%
        private const double TAX_RATE = 0.05;      // Thuế VAT 5%

        public double CalculateTotal(double subtotal)
        {
            if (subtotal > DISCOUNT_THRESHOLD)
            {
                return subtotal * (1 - DISCOUNT_RATE) * (1 + TAX_RATE);
            }
            return subtotal * (1 + TAX_RATE);
        }
    }
}