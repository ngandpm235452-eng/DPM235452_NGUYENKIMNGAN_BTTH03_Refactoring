using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_04_ReplaceMagicNumber
{
    public class Before
    {
        // Code Smell: Sử dụng các con số "kỳ lạ" (Magic Numbers) 1000000, 0.1, 0.05 mà không giải thích ý nghĩa
        public double CalculateTotal(double subtotal)
        {
            if (subtotal > 1000000)
            {
                return subtotal * (1 - 0.1) * (1 + 0.05); // 0.1 và 0.05 là gì?
            }
            return subtotal * (1 + 0.05);
        }
    }
}