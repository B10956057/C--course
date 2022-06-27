using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace B10956057_0516.Models
{
    public class Student
    {
        public Student(string studentNo,string studentName, string githubLink)
        {
            this.StudentNo = studentNo;
            this.StudentName = studentName;
            this.githubLink = githubLink;
        }

        public string StudentNo { get; set; }
        public string StudentName { get; set; }
        public string githubLink { get; set; }

    }
}
