using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_13_RemoveMiddleMan
{
    public class Department
    {
        public string Manager { get; set; } = "Nguyen Van A";
    }

    public class Before
    {
        private Department _department = new Department();

        // Code Smell: Middle Man - Lớp Before chỉ đóng vai trò "chuyển tiếp" cuộc gọi tới Department mà không thực hiện thêm logic nào
        public string GetManager()
        {
            return _department.Manager;
        }
    }
}