using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B10956057_webapi.Models;

namespace B10956057_webapi.service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        (int total, List<Student>) GetStudents(int offset, int count);
        Student GetStudentByStudentNo(string studentNo);

        bool UpdateStudent(Student student);
        bool DeleteStudent(string studentNo);
        bool CreateStudent(Student student);



    }
}
