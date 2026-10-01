using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_15_EncapsulateField
{
    public class Before
    {
        // Code Smell: Public Field - Khai báo biến công khai cho phép truy cập và chỉnh sửa trực tiếp từ bên ngoài, vi phạm tính đóng gói (Encapsulation)
        public string Name;
    }
}