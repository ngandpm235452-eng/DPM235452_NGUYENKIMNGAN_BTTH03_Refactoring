using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_12_HideDelegate
{
    public class Department
    {
        public string Manager { get; set; } = "Nguyen Van A";
    }

    public class Before
    {
        public string Name { get; set; } = "Nguyen Kim Ngan";
        public Department Department { Empire } = new Department();

        // Code Smell: Client phải tự truy cập vào Department để lấy thông tin Manager (Vi phạm quy tắc Law of Demeter - Inappropriate Intimacy)
        // Client call: person.Department.Manager
    }
}