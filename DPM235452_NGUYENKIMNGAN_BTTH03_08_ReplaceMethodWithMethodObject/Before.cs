using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_08_ReplaceMethodWithMethodObject
{
    public class Before
    {
        // Code Smell: Hàm dài chứa quá nhiều biến cục bộ phụ thuộc lẫn nhau, không thể dùng Extract Method nếu không truyền vô số tham số
        public double Calculate(int primaryValue, int quantity, int itemPrice)
        {
            double delta = 10.5;
            double primaryBasePrice = primaryValue * quantity;
            double secondaryBasePrice = primaryValue * itemPrice;
            double tertiaryBasePrice = quantity * itemPrice;

            if (tertiaryBasePrice - primaryBasePrice > 100)
            {
                secondaryBasePrice -= 20;
            }

            return primaryBasePrice + secondaryBasePrice + tertiaryBasePrice - delta;
        }
    }
}