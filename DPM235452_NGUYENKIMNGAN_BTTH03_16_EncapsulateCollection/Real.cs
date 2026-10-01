using System;
using System.Collections.Generic;
using System.Linq;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_16_EncapsulateCollection
{
    // Ứng dụng thực tế: Chống null, kiểm tra trùng lặp tên khóa học và trả về danh sách chỉ đọc an toàn
    public class Real
    {
        private readonly List<Course> _courses = new List<Course>();

        public IReadOnlyCollection<Course> Courses => _courses.AsReadOnly();

        public void AddCourse(Course course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course), "Khóa học không được để trống.");

            if (_courses.Any(c => c.Name.Equals(course.Name, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException($"Khóa học '{course.Name}' đã tồn tại trong danh sách.");

            _courses.Add(course);
        }

        public bool RemoveCourse(string courseName)
        {
            if (string.IsNullOrWhiteSpace(courseName))
                return false;

            var target = _courses.FirstOrDefault(c => c.Name.Equals(courseName, StringComparison.OrdinalIgnoreCase));
            return target != null && _courses.Remove(target);
        }
    }
}