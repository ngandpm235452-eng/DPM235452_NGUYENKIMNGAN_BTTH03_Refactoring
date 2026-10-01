using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_09_SubstituteAlgorithm
{
    public class After
    {
        // Tái cấu trúc: Thay thế toàn bộ thuật toán cũ bằng cấu trúc dữ liệu Danh sách và phương thức tìm kiếm ngắn gọn
        public string FoundPerson(string[] people)
        {
            List<string> candidates = new List<string> { "Don", "John", "Kent" };

            foreach (var person in people)
            {
                if (candidates.Contains(person))
                {
                    return person;
                }
            }
            return "";
        }
    }
}