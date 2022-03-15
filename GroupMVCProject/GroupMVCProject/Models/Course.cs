using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupMVCProject.Models
{
    public class Course
    {
        public virtual int CourseID { get; set; }
        public virtual int CourseName { get; set; }
    }
}