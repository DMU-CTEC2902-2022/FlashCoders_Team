using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamMVCProject.Data;
using System.Data.Entity;

namespace TeamMVCProject.Models
{
    public class ModuleDataInitialiser : DropCreateDatabaseAlways<ModuleContext>
    {
        protected override void Seed(ModuleContext context)
        {
            TeamMVCProject.Models.Module module1 = new TeamMVCProject.Models.Module();
            module1.ModuleID = 1;
            module1.CourseID = 1;
            module1.ModuleCode = "COS1903";
            module1.ModuleTitle = "Scala Programming";
            module1.ModuleDescription = "Learn ways for data processing and web development";
            module1.ModuleContents = "100% Coursework";
            context.Modules.Add(module1);

            TeamMVCProject.Models.Module module2 = new TeamMVCProject.Models.Module();
            module2.ModuleID = 2;
            module2.CourseID = 1;
            module2.ModuleCode = "COS1920";
            module2.ModuleTitle = "Database Management";
            module2.ModuleDescription = "Look into Databases and SQL";
            module2.ModuleContents = "50% Coursework & 50% Exam";
            context.Modules.Add(module2);

            TeamMVCProject.Models.Module module3 = new TeamMVCProject.Models.Module();
            module3.ModuleID = 3;
            module3.CourseID = 1;
            module3.ModuleCode = "COS2905";
            module3.ModuleTitle = "Object Oriented Programming (Java)";
            module3.ModuleDescription = "Creating a retro game using Java";
            module3.ModuleContents = "100% Coursework";
            context.Modules.Add(module3);

            TeamMVCProject.Models.Module module4 = new TeamMVCProject.Models.Module();
            module4.ModuleID = 4;
            module4.CourseID = 1;
            module4.ModuleCode = "COS2910";
            module4.ModuleTitle = "Database Management";
            module4.ModuleDescription = "SQL and Excel skills";
            module4.ModuleContents = "100% Coursework";
            context.Modules.Add(module4);

            TeamMVCProject.Models.Module module5 = new TeamMVCProject.Models.Module();
            module5.ModuleID = 5;
            module5.CourseID = 1;
            module5.ModuleCode = "COS3911";
            module5.ModuleTitle = "Mobile Application";
            module5.ModuleDescription = "Software development skills";
            module5.ModuleContents = "100% Coursework";
            context.Modules.Add(module5);

            TeamMVCProject.Models.Module module6 = new TeamMVCProject.Models.Module();
            module6.ModuleID = 6;
            module6.CourseID = 1;
            module6.ModuleCode = "IMAT3611";
            module6.ModuleTitle = "Computer Ethics and Privacy";
            module6.ModuleDescription = "Look at journal articles and create a literature review on privacy and ethics on technology today";
            module6.ModuleContents = "100% Coursework";
            context.Modules.Add(module6);

            TeamMVCProject.Models.Module module7 = new TeamMVCProject.Models.Module();
            module7.ModuleID = 7;
            module7.CourseID = 1;
            module7.ModuleCode = "COS3451";
            module7.ModuleTitle = "Development Project";
            module7.ModuleDescription = "Final year project create system based on a topic of your choice";
            module7.ModuleContents = "100% Coursework";
            context.Modules.Add(module7);

            TeamMVCProject.Models.Module module8 = new TeamMVCProject.Models.Module();
            module8.ModuleID = 8;
            module8.CourseID = 2;
            module8.ModuleCode = "SE3906";
            module8.ModuleTitle = "Interaction Design";
            module8.ModuleDescription = "Interpret the ways of design of a variety of systems";
            module8.ModuleContents = "100% Exam";
            context.Modules.Add(module8);

            TeamMVCProject.Models.Module module9 = new TeamMVCProject.Models.Module();
            module9.ModuleID = 9;
            module9.CourseID = 2;
            module9.ModuleCode = "SE3410";
            module9.ModuleTitle = "Web Application Penetration Testing";
            module9.ModuleDescription = "Look at different types of ways to test code and how to build a solid web application";
            module9.ModuleContents = "50% Coursework & 50% Exam";
            context.Modules.Add(module9);

            TeamMVCProject.Models.Module module10 = new TeamMVCProject.Models.Module();
            module10.ModuleID = 10;
            module10.CourseID = 2;
            module10.ModuleCode = "SE3406";
            module10.ModuleTitle = "Fuzzy Logic & Knowledge Based Systems";
            module10.ModuleDescription = "Analyse different areas of system";
            module10.ModuleContents = "100% Coursework";
            context.Modules.Add(module10);

            TeamMVCProject.Models.Module module11 = new TeamMVCProject.Models.Module();
            module11.ModuleID = 11;
            module11.CourseID = 2;
            module11.ModuleCode = "SE3613";
            module11.ModuleTitle = "Data Mining";
            module11.ModuleDescription = "SQL and building databases";
            module11.ModuleContents = "100% Coursework";
            context.Modules.Add(module11);

            TeamMVCProject.Models.Module module12 = new TeamMVCProject.Models.Module();
            module12.ModuleID = 12;
            module12.CourseID = 2;
            module12.ModuleCode = "SE3614";
            module12.ModuleTitle = "Big Data & Business Models";
            module12.ModuleDescription = "Research into business intelligence and analytics";
            module12.ModuleContents = "60% Coursework & 40% Exam";
            context.Modules.Add(module12);

            TeamMVCProject.Models.Module module13 = new TeamMVCProject.Models.Module();
            module13.ModuleID = 13;
            module13.CourseID = 2;
            module13.ModuleCode = "IMAT3611";
            module13.ModuleTitle = "Computer Ethics and Privacy";
            module13.ModuleDescription = "Look at journal articles and create a literature review on privacy and ethics on technology today";
            module13.ModuleContents = "100% Coursework";
            context.Modules.Add(module13);

            TeamMVCProject.Models.Module module14 = new TeamMVCProject.Models.Module();
            module14.ModuleID = 14;
            module14.CourseID = 2;
            module14.ModuleCode = "SE3451";
            module14.ModuleTitle = "Development Project";
            module14.ModuleDescription = "Final year project create system based on a topic of your choice";
            module14.ModuleContents = "100% Coursework";
            context.Modules.Add(module14);
            


            TeamMVCProject.Models.Module module15 = new TeamMVCProject.Models.Module();
            module15.ModuleID = 15;
            module15.CourseID = 3;
            module15.ModuleCode = "SE3901";
            module15.ModuleTitle = "C Programming";
            module15.ModuleDescription = "Learn a new language and implement knowledge into building a system from it ";
            module15.ModuleContents = "100% Coursework";
            context.Modules.Add(module15);
           
            TeamMVCProject.Models.Module module16 = new TeamMVCProject.Models.Module();
            module16.ModuleID = 16;
            module16.CourseID = 3;
            module16.ModuleCode = "SE3902";
            module16.ModuleTitle = "Computer Law and Cyber Secuirty Management";
            module16.ModuleDescription = "Learn methods about law and how organisations use security";
            module16.ModuleContents = "30% Coursework & 70% Exam";
            context.Modules.Add(module16);

            TeamMVCProject.Models.Module module17 = new TeamMVCProject.Models.Module();
            module17.ModuleID = 17;
            module17.CourseID = 3;
            module17.ModuleCode = "SE3903";
            module17.ModuleTitle = "Linux Security";
            module17.ModuleDescription = "Use linux to learn different mechanisms for supporting control security policies";
            module17.ModuleContents = "100% Exam";
            context.Modules.Add(module17);

            TeamMVCProject.Models.Module module18 = new TeamMVCProject.Models.Module();
            module18.ModuleID = 18;
            module18.CourseID = 3;
            module18.ModuleCode = "SE3904";
            module18.ModuleTitle = "Cyber Threat Intelligence and Incident Response";
            module18.ModuleDescription = "Cyber Secuirty methods and look at how organisations use methods in real-time";
            module18.ModuleContents = "100% Coursework";
            context.Modules.Add(module18);

            TeamMVCProject.Models.Module module19 = new TeamMVCProject.Models.Module();
            module19.ModuleID = 19;
            module19.CourseID = 3;
            module19.ModuleCode = "SE3905";
            module19.ModuleTitle = "Malware Analysis";
            module19.ModuleDescription = "Learn the process of understanding the behavior and purpose of suspicious files ";
            module19.ModuleContents = "50% Coursework & 50%Exam";
            context.Modules.Add(module19);

            TeamMVCProject.Models.Module module20 = new TeamMVCProject.Models.Module();
            module20.ModuleID = 20;
            module20.CourseID = 3;
            module20.ModuleCode = "IMAT3611";
            module20.ModuleTitle = "Computer Ethics and Privacy";
            module20.ModuleDescription = "Look at journal articles and create a literature review on privacy and ethics on technology today";
            module20.ModuleContents = "100% Coursework";
            context.Modules.Add(module20);

            TeamMVCProject.Models.Module module21 = new TeamMVCProject.Models.Module();
            module21.ModuleID = 21;
            module21.CourseID = 3;
            module21.ModuleCode = "SE3451";
            module21.ModuleTitle = "Development Project";
            module21.ModuleDescription = "Final year project create system based on a topic of your choice";
            module21.ModuleContents = "100% Coursework";
            context.Modules.Add(module21);
            base.Seed(context);
        }



    }
}