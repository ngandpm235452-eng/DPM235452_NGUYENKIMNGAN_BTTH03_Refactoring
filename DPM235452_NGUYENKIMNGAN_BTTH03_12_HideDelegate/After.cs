using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_12_HideDelegate
{
    public class DepartmentAfter
    {
        public string Manager { get; set; } = "Nguyen Van A";
    }

    public class After
    {
        public string Name { get; set; } = "Nguyen Kim Ngan";
        private DepartmentAfter _department = new DepartmentAfter();

        // Tái cấu trúc: Che giấu lớp ủy thác Department, cung cấp phương thức trực tiếp GetManager()
        public string GetManager()
        {
            return _department.Manager;
        }
    }
}
