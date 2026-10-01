using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_02_ReplaceConditional
{
    public enum EmployeeType { FullTime, PartTime, Intern }

    public class Before
    {
        // Code Smell: Dùng switch/case để tính lương dựa trên loại nhân viên
        public double CalculateSalary(EmployeeType type, double baseSalary)
        {
            switch (type)
            {
                case EmployeeType.FullTime:
                    return baseSalary * 1.2;
                case EmployeeType.PartTime:
                    return baseSalary * 0.8;
                case EmployeeType.Intern:
                    return baseSalary * 0.5;
                default:
                    throw new ArgumentException("Loại nhân viên không hợp lệ");
            }
        }
    }
}