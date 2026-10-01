using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_06_ReplaceNestedConditionalWithGuard
{
    public class After
    {
        // Tái cấu trúc: Sử dụng Guard Clauses (các câu lệnh kiểm tra điều kiện thoát sớm return) giúp phẳng hóa luồng xử lý
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired, double basePay)
        {
            if (isDead) return basePay * 0.1;
            if (isSeparated) return basePay * 0.5;
            if (isRetired) return basePay * 0.8;

            return basePay;
        }
    }
}