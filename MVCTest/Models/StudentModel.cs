using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class StudentModel
    {

        public int id { get; set; }
        [Display(Name ="姓名")]
        [Required(ErrorMessage ="请输入姓名")]
        public string Name { get; set; }

        [Display(Name = "班级")]
        public ClassNameEnum ClassName { get; set; }

        [Display(Name = "邮箱")]
        [Required(ErrorMessage = "请输入邮箱地址")]
        public string Email { get; set; }
    }
}
