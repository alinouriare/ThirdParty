using Entities.Courses;

namespace Entities.Students
{
    public class StudentCourse
    {
        public int StudentCourseId { get; set; }

        public virtual Student Student { get; set; }

        public virtual  Course Course { get; set; }
    }
}
