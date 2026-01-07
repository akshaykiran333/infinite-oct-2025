using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Html_Helpr_prj.Models
{
    public class Student
    {
        [Display(Name="Student roll number")]
        public int Rno { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}