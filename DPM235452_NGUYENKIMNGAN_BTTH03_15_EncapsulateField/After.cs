using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_15_EncapsulateField
{
    public class After
    {
        // Tái cấu trúc: Chuyển biến thành private field và quản lý qua các phương thức Getter/Setter
        private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}