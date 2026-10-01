using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_12_HideDelegate
{
    // Ứng dụng thực tế: Đóng gói hoàn toàn đối tượng liên kết, kiểm tra Null-safety và khởi tạo qua Constructor
    public class DepartmentReal
    {
        public string DepartmentName { get; }
        public string ManagerName { get; }

        public DepartmentReal(string departmentName, string managerName)
        {
            DepartmentName = string.IsNullOrWhiteSpace(departmentName) ? "Chưa xếp phòng" : departmentName;
            ManagerName = string.IsNullOrWhiteSpace(managerName) ? "Chưa có quản lý" : managerName;
        }
    }

    public class Real
    {
        public string EmployeeName { get; }
        private readonly DepartmentReal _department;

        public Real(string employeeName, DepartmentReal department)
        {
            if (string.IsNullOrWhiteSpace(employeeName))
                throw new ArgumentException("Tên nhân viên không được để trống.", nameof(employeeName));

            EmployeeName = employeeName;
            _department = department ?? throw new ArgumentNullException(nameof(department));
        }

        public string DepartmentManager => _department.ManagerName;
        public string DepartmentInfo => $"{_department.DepartmentName} (Quản lý: {_department.ManagerName})";
    }
}