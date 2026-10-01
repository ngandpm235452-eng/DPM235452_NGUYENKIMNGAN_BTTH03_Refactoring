using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_17_ReplaceDataValueWithObject
{
    public class Before
    {
        // Code Smell: Primitive Obsession - Dùng kiểu chuỗi string thô đại diện cho thông tin Khách hàng (Customer)
        public string Customer { get; set; }

        public Before(string customer)
        {
            Customer = customer;
        }
    }
}