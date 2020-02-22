using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class DBStudentRepository : IStudentRespository
    {

        private readonly AppDbContext context;


        public DBStudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public StudentModel AddStudent(StudentModel newStudent)
        {
            context.Add(newStudent);
            context.SaveChanges();
            return newStudent;
        }

        public StudentModel DeleteStudent(int id)
        {
            StudentModel student = context.StudentModels.Find(id);
            if (student != null)
            {
                context.StudentModels.Remove(student);
                context.SaveChanges();
            }
            return student;
        }

        public List<StudentModel> GetAllStudents()
        {
            return context.StudentModels.ToList();
        }

        public StudentModel GetStudent(int id)
        {
            return context.StudentModels.Find(id);
        }

        public StudentModel UpdateStudent(StudentModel updateStudent)
        {
            var student = context.StudentModels.Attach(updateStudent);

            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            context.SaveChanges();

            return updateStudent;
        }
    }


}
