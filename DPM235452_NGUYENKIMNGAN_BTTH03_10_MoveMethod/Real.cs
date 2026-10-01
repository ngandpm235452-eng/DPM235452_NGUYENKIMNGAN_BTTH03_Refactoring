using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_10_MoveMethod
{
    // Ứng dụng thực tế: Đóng gói thuộc tính qua Constructor, kiểm tra hợp lệ dữ liệu và đưa các hằng số tính phí vào lớp sở hữu
    public class AccountTypeReal
    {
        public bool IsPremium { get; }
        private const double BASE_PREMIUM_CHARGE = 10.0;
        private const double PREMIUM_DAILY_RATE = 1.5;
        private const double REGULAR_DAILY_RATE = 1.75;
        private const int PREMIUM_GRACE_DAYS = 7;

        public AccountTypeReal(bool isPremium)
        {
            IsPremium = isPremium;
        }

        public double CalculateOverdraftCharge(int daysOverdrawn)
        {
            if (daysOverdrawn < 0)
                throw new ArgumentOutOfRangeException(nameof(daysOverdrawn), "Số ngày thấu chi không được âm.");

            if (IsPremium)
            {
                double charge = BASE_PREMIUM_CHARGE;
                if (daysOverdrawn > PREMIUM_GRACE_DAYS)
                    charge += (daysOverdrawn - PREMIUM_GRACE_DAYS) * PREMIUM_DAILY_RATE;
                return charge;
            }

            return daysOverdrawn * REGULAR_DAILY_RATE;
        }
    }

    public class Real
    {
        public AccountTypeReal Type { get; }
        public int DaysOverdrawn { get; }
        private const double BASE_BANK_FEE = 4.5;

        public Real(AccountTypeReal type, int daysOverdrawn)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
            if (daysOverdrawn < 0)
                throw new ArgumentOutOfRangeException(nameof(daysOverdrawn), "Số ngày thấu chi không được âm.");

            DaysOverdrawn = daysOverdrawn;
        }

        public double CalculateBankCharge()
        {
            double totalFee = BASE_BANK_FEE;
            if (DaysOverdrawn > 0)
            {
                totalFee += Type.CalculateOverdraftCharge(DaysOverdrawn);
            }
            return totalFee;
        }
    }
}