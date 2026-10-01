using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_10_MoveMethod
{
    public class AccountType
    {
        public bool IsPremium { get; set; }
    }

    public class Before
    {
        public AccountType Type { get; set; } = new AccountType();
        public int DaysOverdrawn { get; set; }

        // Code Smell: Feature Envy - Phương thức OverdraftCharge truy cập dữ liệu của AccountType nhiều hơn lớp chứa nó
        public double OverdraftCharge()
        {
            if (Type.IsPremium)
            {
                double result = 10;
                if (DaysOverdrawn > 7)
                    result += (DaysOverdrawn - 7) * 1.5;
                return result;
            }
            else
            {
                return DaysOverdrawn * 1.75;
            }
        }

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
                result += OverdraftCharge();
            return result;
        }
    }
}