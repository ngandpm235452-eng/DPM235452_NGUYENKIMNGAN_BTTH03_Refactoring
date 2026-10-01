using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_13_RemoveMiddleMan
{
    // Ứng dụng thực tế: Loại bỏ trung gian dư thừa, đóng gói bằng thuộc tính readonly và đảm bảo Null-safety
    public class DepartmentReal
    {
        public string Name { get; }
        public string Manager { get; }

        public DepartmentReal(string name, string manager)
        {
            Name = string.IsNullOrWhiteSpace(name) ? "Phòng chưa xác định" : name;
            Manager = string.IsNullOrWhiteSpace(manager) ? "Chưa có quản lý" : manager;
        }
    }

    public class Real
    {
        public string EmployeeName { get; }
        public DepartmentReal Department { get; }

        public Real(string employeeName, DepartmentReal department)
        {
            if (string.IsNullOrWhiteSpace(employeeName))
                throw new ArgumentException("Tên nhân viên không được để trống.", nameof(employeeName));

            EmployeeName = employeeName;
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }
    }
}