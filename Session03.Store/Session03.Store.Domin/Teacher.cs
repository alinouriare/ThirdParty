using System;
using System.Collections.Generic;
using System.Text;

namespace Session03.Store.Domin
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }



    }

    public class TeacherCourse
    {
        public int TeacherCourseId { get; set; }
        public Teacher  Teacher { get; set; }

        public Course Course  { get; set; }

    }


    public class Course
    {

        public int CourseId { get; set; }

        public String Name { get; set; }
    }

    public class TeacherStudent
    {
        public int TeacherStudentId { get; set; }

        public Teacher  Teacher { get; set; }

        public Student  Student { get; set; }
    }


    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
