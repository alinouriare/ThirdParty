using Entities.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Teachers
{
    public class TeacherCourse
    {

        public int TeacherCourseId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}
