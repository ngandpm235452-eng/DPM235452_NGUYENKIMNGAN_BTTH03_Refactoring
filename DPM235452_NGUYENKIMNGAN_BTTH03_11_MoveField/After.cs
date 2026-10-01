using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_11_MoveField
{
    public class AccountTypeAfter
    {
        public string Name { get; set; } = "Savings";
        // Tái cấu trúc: Di chuyển thuộc tính InterestRate sang lớp AccountTypeAfter
        public double InterestRate { get; set; } = 0.05;
    }

    public class After
    {
        public AccountTypeAfter Type { get; set; } = new AccountTypeAfter();

        public double CalculateInterest(double amount)
        {
            return amount * Type.InterestRate;
        }
    }
}
