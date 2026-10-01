using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_16_EncapsulateCollection
{
    public class After
    {
        private readonly List<Course> _courses = new List<Course>();

        // Tái cấu trúc: Trả về IReadOnlyList và quản lý việc thêm/xóa phần tử thông qua các phương thức riêng
        public IReadOnlyList<Course> Courses => _courses.AsReadOnly();

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }
    }
}