using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public interface IStudentRespository
    {
        StudentModel GetStudent(int id);

        List<StudentModel> GetAllStudents();

        StudentModel AddStudent(StudentModel newStudent);

        StudentModel UpdateStudent(StudentModel updateStudent);

        StudentModel DeleteStudent(int id);
    }
}
