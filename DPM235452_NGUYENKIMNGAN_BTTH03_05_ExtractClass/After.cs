using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_05_ExtractClass
{
    // Tách các thuộc tính và phương thức liên quan đến số điện thoại sang một lớp riêng
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public string GetTelephoneNumber()
        {
            return $"({AreaCode}) {Number}";
        }
    }

    public class After
    {
        public string Name { get; set; }
        public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();
    }
}