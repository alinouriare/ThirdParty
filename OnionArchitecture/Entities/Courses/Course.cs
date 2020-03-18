using Entities.Students;
using Entities.Teachers;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Courses
{
    public class Course
    {
        //private readonly ILazyLoader lazyLoader;

        //public Course(ILazyLoader lazyLoader)
        //{
        //    this.lazyLoader = lazyLoader;
        //}


        public int CourseId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }


        public virtual List<StudentCourse> Students { get; set; }

        public virtual List<TeacherCourse> Teachers { get; set; }


        //private List<TeacherCourse> _teachers;

        //public List<TeacherCourse> Teachers
        //{ get {

        //        lazyLoader.Load(this, "Teachers");
        //        return _teachers;
        //    } set { _teachers = value; } }
    }
}
