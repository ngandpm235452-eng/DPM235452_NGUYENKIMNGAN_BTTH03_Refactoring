using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_13_RemoveMiddleMan
{
    public class DepartmentAfter
    {
        public string Manager { get; set; } = "Nguyen Van A";
    }

    public class After
    {
        // Tái cấu trúc: Bỏ phương thức chuyển tiếp GetManager(), bộc lộ đối tượng DepartmentAfter để Client truy cập trực tiếp
        public DepartmentAfter Department { get; } = new DepartmentAfter();
    }
}