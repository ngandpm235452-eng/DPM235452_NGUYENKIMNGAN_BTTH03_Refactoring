using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_06_ReplaceNestedConditionalWithGuard
{
    public class Before
    {
        // Code Smell: if-else lồng nhau quá nhiều cấp (Arrow Anti-pattern / Deep Nesting) gây khó đọc và bảo trì
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired, double basePay)
        {
            double result;
            if (isDead)
            {
                result = basePay * 0.1;
            }
            else
            {
                if (isSeparated)
                {
                    result = basePay * 0.5;
                }
                else
                {
                    if (isRetired)
                    {
                        result = basePay * 0.8;
                    }
                    else
                    {
                        result = basePay;
                    }
                }
            }
            return result;
        }
    }
}