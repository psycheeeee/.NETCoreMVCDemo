using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class MockStudentRespository:IStudentRespository
    {
        private List<StudentModel> _studentList;
        public MockStudentRespository()
        {
            _studentList = new List<StudentModel>() {
            new StudentModel(){ id=1,Name="张三",ClassName=ClassNameEnum.One,Email="zhangsan@syinpo.com"},
            new StudentModel(){ id=2,Name="李四",ClassName=ClassNameEnum.Two,Email="lisi@syinpo.com"},
            new StudentModel(){ id=3,Name="杨广超",ClassName=ClassNameEnum.Three,Email="YGC@syinpo.com"}
            };
        }

        public StudentModel AddStudent(StudentModel newStudent)
        {
            int id = _studentList.Max(d => d.id) + 1;
            newStudent.id = id;
            _studentList.Add(newStudent);
            return newStudent;
        }

        public StudentModel DeleteStudent(int id)
        {
            StudentModel student = _studentList.FirstOrDefault(d => d.id == id);

            if (student != null)
            {
                _studentList.Remove(student);
            }
            return student;
        }

        public List<StudentModel> GetAllStudents()
        {
            return _studentList;
        }

        public StudentModel GetStudent(int id)
        {
            return _studentList.Where(d=>d.id==id).FirstOrDefault();
        }

        public StudentModel UpdateStudent(StudentModel updateStudent)
        {
            StudentModel student = _studentList.FirstOrDefault(d => d.id == updateStudent.id);

            if (student != null)
            {
                student.Name = updateStudent.Name;
                student.ClassName = updateStudent.ClassName;
                student.Email = updateStudent.Email;
            }
            return student;
        }
    }
}
