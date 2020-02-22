using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public enum ClassNameEnum
    {
        [Display(Name = "一年级")]
        One,
        [Display(Name = "二年级")]
        Two,
        [Display(Name = "三年级")]
        Three
    }
}
