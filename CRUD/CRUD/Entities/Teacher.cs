using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Entities
{
    public class Teacher
    {

        public int TeacherId { get; set; }


        public string Name { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();

        public bool Fired { get; set; }

    }
}
