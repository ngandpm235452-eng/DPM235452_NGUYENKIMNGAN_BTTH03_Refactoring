using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_08_ReplaceMethodWithMethodObject
{
    // Tách cả phương thức thành một Class riêng (Method Object)
    public class OrderCalculatorAfter
    {
        private readonly int _primaryValue;
        private readonly int _quantity;
        private readonly int _itemPrice;

        private double _primaryBasePrice;
        private double _secondaryBasePrice;
        private double _tertiaryBasePrice;

        public OrderCalculatorAfter(int primaryValue, int quantity, int itemPrice)
        {
            _primaryValue = primaryValue;
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double Compute()
        {
            double delta = 10.5;
            _primaryBasePrice = _primaryValue * _quantity;
            _secondaryBasePrice = _primaryValue * _itemPrice;
            _tertiaryBasePrice = _quantity * _itemPrice;

            ApplyDiscount();

            return _primaryBasePrice + _secondaryBasePrice + _tertiaryBasePrice - delta;
        }

        private void ApplyDiscount()
        {
            if (_tertiaryBasePrice - _primaryBasePrice > 100)
            {
                _secondaryBasePrice -= 20;
            }
        }
    }

    public class After
    {
        public double Calculate(int primaryValue, int quantity, int itemPrice)
        {
            return new OrderCalculatorAfter(primaryValue, quantity, itemPrice).Compute();
        }
    }
}