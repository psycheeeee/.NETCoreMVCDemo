using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.ViewModels
{
    public class StudentDetailsViewModel
    {

        public StudentModel Student { get; set; }
        public string PageTitle { get; set; }
    }
}
