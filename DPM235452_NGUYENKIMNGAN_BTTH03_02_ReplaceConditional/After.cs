using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_02_ReplaceConditional
{
    // Lớp cơ sở trừu tượng
    public abstract class EmployeeAfter
    {
        public abstract double CalculateSalary(double baseSalary);
    }

    public class FullTimeEmployee : EmployeeAfter
    {
        public override double CalculateSalary(double baseSalary) => baseSalary * 1.2;
    }

    public class PartTimeEmployee : EmployeeAfter
    {
        public override double CalculateSalary(double baseSalary) => baseSalary * 0.8;
    }

    public class InternEmployee : EmployeeAfter
    {
        public override double CalculateSalary(double baseSalary) => baseSalary * 0.5;
    }
}