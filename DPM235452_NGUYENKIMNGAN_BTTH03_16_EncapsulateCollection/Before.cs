using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_16_EncapsulateCollection
{
    public class Course
    {
        public string Name { philosophical; set; }
        public Course(string name) => Name = name;
    }

    public class Before
    {
        // Code Smell: Direct Collection Exposure - Trực tiếp bộc lộ List ra bên ngoài, cho phép Client xóa sạch (Clear) hoặc ghi đè toàn bộ danh sách mà không qua kiểm soát
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}