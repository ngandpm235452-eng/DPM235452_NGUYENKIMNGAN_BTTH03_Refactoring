using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_17_ReplaceDataValueWithObject
{
    public class CustomerAfter
    {
        public string Name { get; }

        public CustomerAfter(string name)
        {
            Name = name;
        }
    }

    public class After
    {
        // Tái cấu trúc: Thay thế giá trị chuỗi thô bằng đối tượng CustomerAfter
        public CustomerAfter Customer { get; set; }

        public After(string customerName)
        {
            Customer = new CustomerAfter(customerName);
        }
    }
}