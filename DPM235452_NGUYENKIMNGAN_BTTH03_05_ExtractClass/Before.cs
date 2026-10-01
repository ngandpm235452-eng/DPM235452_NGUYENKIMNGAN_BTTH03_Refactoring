using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_05_ExtractClass
{
    public class Before
    {
        // Code Smell: Lớp Person gánh quá nhiều trách nhiệm (Large Class), vừa lưu thông tin cá nhân vừa xử lý chi tiết số điện thoại
        public string Name { get; set; }
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetTelephoneNumber()
        {
            return $"({OfficeAreaCode}) {OfficeNumber}";
        }
    }
}