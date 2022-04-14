using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TeamMVCProject.Data;

namespace TeamMVCProject.Models
{
    public class CollegeDataInitialiser : DropCreateDatabaseAlways<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            TeamMVCProject.Models.Course course1 = new TeamMVCProject.Models.Course();
            course1.CourseID = 1;
            course1.CourseName = "Computer Science";
            context.Courses.Add(course1);

            TeamMVCProject.Models.Course course2 = new TeamMVCProject.Models.Course();
            course2.CourseID = 2;
            course2.CourseName = "Software Engineering";
            context.Courses.Add(course2);

            TeamMVCProject.Models.Course course3 = new TeamMVCProject.Models.Course();
            course3.CourseID = 3;
            course3.CourseName = "Cyber Security";
            context.Courses.Add(course3);


            base.Seed(context);


        }
    }
    
}