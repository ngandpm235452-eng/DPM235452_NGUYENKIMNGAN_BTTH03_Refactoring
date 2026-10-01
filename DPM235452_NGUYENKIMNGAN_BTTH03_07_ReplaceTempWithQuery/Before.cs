using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_07_ReplaceTempWithQuery
{
    public class Before
    {
        private int _quantity = 5;
        private double _itemPrice = 250000;

        // Code Smell: Dùng các biến tạm (basePrice, discountFactor) lưu kết quả tính toán trung gian, làm rác phương thức và khó tái sử dụng
        public double CalculateTotal()
        {
            double basePrice = _quantity * _itemPrice;
            double discountFactor;

            if (basePrice > 1000000)
                discountFactor = 0.95;
            else
                discountFactor = 0.98;

            return basePrice * discountFactor;
        }
    }
}