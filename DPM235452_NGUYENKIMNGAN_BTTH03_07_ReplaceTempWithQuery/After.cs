using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_07_ReplaceTempWithQuery
{
    public class After
    {
        private int _quantity = 5;
        private double _itemPrice = 250000;

        // Tái cấu trúc: Thay thế các biến tạm bằng các phương thức truy vấn (Query Methods)
        public double CalculateTotal()
        {
            return GetBasePrice() * GetDiscountFactor();
        }

        private double GetBasePrice() => _quantity * _itemPrice;

        private double GetDiscountFactor() => GetBasePrice() > 1000000 ? 0.95 : 0.98;
    }
}