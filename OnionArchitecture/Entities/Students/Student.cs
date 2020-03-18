using Entities.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Students
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public virtual  List<StudentCourse> Courses { get; set; }


    }
}
