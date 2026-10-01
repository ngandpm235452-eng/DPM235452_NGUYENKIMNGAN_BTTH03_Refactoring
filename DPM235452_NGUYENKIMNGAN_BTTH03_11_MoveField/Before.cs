using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_11_MoveField
{
    public class AccountType
    {
        public string Name { get; set; } = "Savings";
    }

    public class Before
    {
        public AccountType Type { get; set; } = new AccountType();
        // Code Smell: Thuộc tính InterestRate đặt tại Account nhưng thực chất thuộc tính này do AccountType quy định
        public double InterestRate { get; set; } = 0.05;

        public double CalculateInterest(double amount)
        {
            return amount * InterestRate;
        }
    }
}