using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_14_InlineClass
{
    public class TelephoneNumber
    {
        public string AreaCode { get; set; } = "028";
        public string Number { get; set; } = "12345678";
    }

    public class Before
    {
        public string Name { get; set; } = "Nguyen Kim Ngan";
        // Code Smell: Lazy Class / Freeloader - Lớp TelephoneNumber quá nhỏ, hầu như không có logic xử lý gì đáng để tách thành một Class riêng
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();

        public string GetFullPhone()
        {
            return $"({Phone.AreaCode}) {Phone.Number}";
        }
    }
}