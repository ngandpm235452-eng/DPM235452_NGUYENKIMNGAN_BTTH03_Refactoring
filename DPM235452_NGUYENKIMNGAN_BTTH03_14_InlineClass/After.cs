using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_14_InlineClass
{
    // Tái cấu trúc: Gộp toàn bộ thuộc tính của TelephoneNumber trở lại lớp After để đơn giản hóa cấu trúc dự án
    public class After
    {
        public string Name { get; set; } = "Nguyen Kim Ngan";
        public string AreaCode { get; set; } = "028";
        public string Number { get; set; } = "12345678";

        public string GetFullPhone()
        {
            return $"({AreaCode}) {Number}";
        }
    }
}