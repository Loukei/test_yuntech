using System.ComponentModel.DataAnnotations;

namespace MvcSchool.Models
{
    public class Student
    {
        /// 學號
        public int STUD_NO { get; set; }
        /// 姓名
        public string? STUD_NAME { get; set; }
        /// 性別 尊重多元性別
        public string? SEX { get; set; }
        /// 就讀系所代碼
        public string? DEPT_CODE { get; set; }
        /// 電話
        public string? TEL { get; set; }
        /// 地址
        public string? ADDRESS { get; set; }
    }
}