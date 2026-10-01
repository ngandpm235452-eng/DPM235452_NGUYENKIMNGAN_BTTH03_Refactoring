using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_14_InlineClass
{
    // Ứng dụng thực tế: Đóng gói thuộc tính readonly, kiểm tra tính hợp lệ của mã vùng và số điện thoại
    public class Real
    {
        public string Name { get; }
        public string AreaCode { get; }
        public string PhoneNumber { get; }

        public Real(string name, string areaCode, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên không được để trống.", nameof(name));
            if (string.IsNullOrWhiteSpace(areaCode))
                throw new ArgumentException("Mã vùng không được để trống.", nameof(areaCode));
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Số điện thoại không được để trống.", nameof(phoneNumber));

            Name = name;
            AreaCode = areaCode;
            PhoneNumber = phoneNumber;
        }

        public string FullPhone => $"({AreaCode}) {PhoneNumber}";
    }
}