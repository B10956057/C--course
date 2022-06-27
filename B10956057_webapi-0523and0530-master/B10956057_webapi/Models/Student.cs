using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace B10956057_webapi.Models
{
    public class Student : IBaseData
    {
        [Key]
        [DisplayName("學號")]
        public string studentNo { get; set; }

        [Required(ErrorMessage = "姓名不可為空白")]
        [DisplayName("姓名")]
        public string studentName { get; set; }
        
        [MinLength(10, ErrorMessage = "長度不可小於10")]
        [DisplayName("GitHubs連結")]
        public string githubLink { get; set; }
        public bool isDelete { get; set; }
        public DateTime creDateTime { get; set; }
        public DateTime updateDateTime { get; set; }


        public Student(string studentNo, string studentName, string githubLink)
        {
            this.studentNo = studentNo;
            this.studentName = studentName;
            this.githubLink = githubLink;
        }

        public Student()
        {

        }
    }
    
}
