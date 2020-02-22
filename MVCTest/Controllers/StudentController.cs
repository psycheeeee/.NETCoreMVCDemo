using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTest.Models;
using MVCTest.ViewModels;

namespace MVCTest.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentRespository _studentRespository;
        public StudentController(IStudentRespository studentRespository)
        {
            _studentRespository = studentRespository;
        }
        [Route("Student/StudentDetail/{id?}")]
        public IActionResult StudentDetail(int? id)
        {
            ViewData["Title"] = "学生详情";
            StudentModel student = _studentRespository.GetStudent(id ?? 1);

            StudentDetailsViewModel model = new StudentDetailsViewModel()
            {
                Student = student,
                PageTitle = "学生详情"
            };

            //ViewData["PageTitle"] = "学生详情";
            //ViewData["StudentDetail"] = student;

            //ViewBag.PageTitle = "学生详情";
            //ViewBag.StudentDetail= student;
            return View(model);
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "学生列表页";
            List<StudentModel> studentList = _studentRespository.GetAllStudents();
            return View(studentList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "创建学生";
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentModel student)
        {

            if (ModelState.IsValid)
            {
                StudentModel newStudent = _studentRespository.AddStudent(student);
                //return RedirectToAction("StudentDetail", new { id = newStudent.id });
            }
           
                return View();

        }
        public IActionResult Delete(int Id)
        {
            StudentModel deleteStudent = _studentRespository.DeleteStudent(Id);
            return RedirectToAction("Index");
        }
    }
}