﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GroupMVCProject.Data;

namespace GroupMVCProject.Models
{
    public class CollegeDataInitialiser : DropCreateDatabaseAlways<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            GroupMVCProject.Models.Course course1 = new GroupMVCProject.Models.Course();
            course1.CourseID = 1;
            course1.CourseName = "Computer Science";
            context.Courses.Add(course1);

            GroupMVCProject.Models.Course course2 = new GroupMVCProject.Models.Course();
            course2.CourseID = 2;
            course2.CourseName = "Software Engineering";
            context.Courses.Add(course2);

            GroupMVCProject.Models.Course course3 = new GroupMVCProject.Models.Course();
            course3.CourseID = 3;
            course3.CourseName = "Cyber Security";
            context.Courses.Add(course3);

            //............. test commit

            GroupMVCProject.Models.Module module1 = new GroupMVCProject.Models.Module();
            module1.ModuleID = 1;
            module1.CourseID = 1;
            module1.ModuleCode = "COS1903";
            module1.ModuleTitle = "Scala Programming";

            GroupMVCProject.Models.Module module2 = new GroupMVCProject.Models.Module();
            module2.ModuleID = 2;
            module2.CourseID = 1;
            module2.ModuleCode = "COS1920";
            module2.ModuleTitle = "Database Management";

            GroupMVCProject.Models.Module module3 = new GroupMVCProject.Models.Module();
            module3.ModuleID = 3;
            module3.CourseID = 1;
            module3.ModuleCode = "COS2905";
            module3.ModuleTitle = "Object Oriented Programming (Java)";

            GroupMVCProject.Models.Module module4 = new GroupMVCProject.Models.Module();
            module4.ModuleID = 4;
            module4.CourseID = 1;
            module4.ModuleCode = "COS2910";
            module4.ModuleTitle = "Database Management";

            GroupMVCProject.Models.Module module5 = new GroupMVCProject.Models.Module();
            module5.ModuleID = 5;
            module5.CourseID = 1;
            module5.ModuleCode = "COS3911";
            module5.ModuleTitle = "Mobile Application";

            GroupMVCProject.Models.Module module6 = new GroupMVCProject.Models.Module();
            module6.ModuleID = 6;
            module6.CourseID = 1;
            module6.ModuleCode = "IMAT3611";
            module6.ModuleTitle = "Computer Ethics and Privacy";

            GroupMVCProject.Models.Module module7 = new GroupMVCProject.Models.Module();
            module7.ModuleID = 7;
            module7.CourseID = 1;
            module7.ModuleCode = "COS3451";
            module7.ModuleTitle = "Development Project";

            GroupMVCProject.Models.Module module8 = new GroupMVCProject.Models.Module();
            module8.ModuleID = 8;
            module8.CourseID = 2;
            module8.ModuleCode = "SE3906";
            module8.ModuleTitle = "Interaction Design";

            GroupMVCProject.Models.Module module9 = new GroupMVCProject.Models.Module();
            module9.ModuleID = 9;
            module9.CourseID = 2;
            module9.ModuleCode = "SE3410";
            module9.ModuleTitle = "Web Application Penetration Testing";

            GroupMVCProject.Models.Module module10 = new GroupMVCProject.Models.Module();
            module10.ModuleID = 10;
            module10.CourseID = 2;
            module10.ModuleCode = "SE3406";
            module10.ModuleTitle = "Fuzzy Logic & Knowledge Based Systems";

            GroupMVCProject.Models.Module module11 = new GroupMVCProject.Models.Module();
            module11.ModuleID = 11;
            module11.CourseID = 2;
            module11.ModuleCode = "SE3613";
            module11.ModuleTitle = "Data Mining";

            GroupMVCProject.Models.Module module12 = new GroupMVCProject.Models.Module();
            module12.ModuleID = 12;
            module12.CourseID = 2;
            module12.ModuleCode = "SE3614";
            module12.ModuleTitle = "Big Data & Business Models";

            GroupMVCProject.Models.Module module13 = new GroupMVCProject.Models.Module();
            module13.ModuleID = 13;
            module13.CourseID = 2;
            module13.ModuleCode = "IMAT3611";
            module13.ModuleTitle = "Computer Ethics and Privacy";

            GroupMVCProject.Models.Module module14 = new GroupMVCProject.Models.Module();
            module14.ModuleID = 14;
            module14.CourseID = 2;
            module14.ModuleCode = "SE3451";
            module14.ModuleTitle = "Development Project";

            GroupMVCProject.Models.Module module15 = new GroupMVCProject.Models.Module();
            module15.ModuleID = 15;
            module15.CourseID = 3;
            module15.ModuleCode = "SE3901";
            module15.ModuleTitle = "C Programming";

            GroupMVCProject.Models.Module module16 = new GroupMVCProject.Models.Module();
            module16.ModuleID = 16;
            module16.CourseID = 3;
            module16.ModuleCode = "SE3902";
            module16.ModuleTitle = "Computer Law and Cyber Secuirty Management";

            GroupMVCProject.Models.Module module17 = new GroupMVCProject.Models.Module();
            module17.ModuleID = 17;
            module17.CourseID = 3;
            module17.ModuleCode = "SE3903";
            module17.ModuleTitle = "Linux Security";

            GroupMVCProject.Models.Module module18 = new GroupMVCProject.Models.Module();
            module18.ModuleID = 18;
            module18.CourseID = 3;
            module18.ModuleCode = "SE3904";
            module18.ModuleTitle = "Cyber Threat Intelligence and Incident Response";

            GroupMVCProject.Models.Module module19 = new GroupMVCProject.Models.Module();
            module19.ModuleID = 19;
            module19.CourseID = 3;
            module19.ModuleCode = "SE3905";
            module19.ModuleTitle = "Malware Analysis";

            GroupMVCProject.Models.Module module20 = new GroupMVCProject.Models.Module();
            module20.ModuleID = 20;
            module20.CourseID = 3;
            module20.ModuleCode = "IMAT3611";
            module20.ModuleTitle = "Computer Ethics and Privacy";

            GroupMVCProject.Models.Module module21 = new GroupMVCProject.Models.Module();
            module21.ModuleID = 21;
            module21.CourseID = 3;
            module21.ModuleCode = "SE3451";
            module21.ModuleTitle = "Development Project";

            base.Seed(context);


        }
    }
    
}