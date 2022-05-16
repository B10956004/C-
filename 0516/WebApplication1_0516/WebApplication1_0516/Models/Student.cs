using System.ComponentModel.DataAnnotations;
namespace WebApplication1_0516.Models
{
    public class Student
    {
        [Key]
        public string studentNo { get; set; }

        [Required(ErrorMessage ="姓名不可空白")]
        public string studentName { get; set; }

        [MinLength(10,ErrorMessage ="長度不可小於10")]
        public string githubLink { get; set; }

        public Student(string studentNo,string studentName,string githubLink)
        {
            this.studentNo = studentNo;
            this.studentName = studentName;
            this.githubLink = githubLink;
        }
        public Student()
        {
            //更新資料
        }
    }
}
