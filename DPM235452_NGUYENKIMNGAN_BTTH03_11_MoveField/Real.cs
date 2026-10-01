using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_11_MoveField
{
    // Ứng dụng thực tế: Đóng gói thuộc tính readonly, kiểm tra điều kiện lãi suất hợp lệ (0% - 100%)
    public class AccountTypeReal
    {
        public string Name { get; }
        public double InterestRate { get; }

        public AccountTypeReal(string name, double interestRate)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên loại tài khoản không được để trống.", nameof(name));
            if (interestRate < 0.0 || interestRate > 1.0)
                throw new ArgumentOutOfRangeException(nameof(interestRate), "Lãi suất phải nằm trong khoảng từ 0.0 đến 1.0 (0% - 100%).");

            Name = name;
            InterestRate = interestRate;
        }
    }

    public class Real
    {
        public AccountTypeReal Type { get; }

        public Real(AccountTypeReal type)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public double CalculateInterest(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Số tiền gửi không được nhỏ hơn 0.");

            return amount * Type.InterestRate;
        }
    }
}