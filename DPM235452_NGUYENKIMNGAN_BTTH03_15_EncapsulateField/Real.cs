using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_15_EncapsulateField
{
    // Ứng dụng thực tế: Sử dụng C# Auto-Property với private set, kiểm tra điều kiện dữ liệu (Validation) và làm sạch chuỗi
    public class Real
    {
        public string Name { get; private set; }

        public Real(string name)
        {
            UpdateName(name);
        }

        public void UpdateName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("Tên không được để trống hoặc chỉ chứa khoảng trắng.", nameof(newName));

            Name = newName.Trim();
        }
    }
}