using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Entities
{
  public  class Course
    {

        public int CourseId { get; set; }


        public string Name { get; set; }


        public Teacher  Teacher { get; set; }


    }
}
