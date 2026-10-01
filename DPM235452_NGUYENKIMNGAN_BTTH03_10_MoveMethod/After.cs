using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_10_MoveMethod
{
    public class AccountTypeAfter
    {
        public bool IsPremium { get; set; }

        // Tái cấu trúc: Di chuyển phương thức OverdraftCharge sang lớp AccountTypeAfter - nơi sở hữu trực tiếp thuộc tính IsPremium
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                double result = 10;
                if (daysOverdrawn > 7)
                    result += (daysOverdrawn - 7) * 1.5;
                return result;
            }
            else
            {
                return daysOverdrawn * 1.75;
            }
        }
    }

    public class After
    {
        public AccountTypeAfter Type { get; set; } = new AccountTypeAfter();
        public int DaysOverdrawn { get; set; }

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
                result += Type.OverdraftCharge(DaysOverdrawn);
            return result;
        }
    }
}