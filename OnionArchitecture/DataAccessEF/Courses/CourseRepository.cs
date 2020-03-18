using Contracts.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessEF.Courses
{
    public class CourseRepository : ICourseRepository
    {
        private readonly StoreDbContext storeDbContext;

        public CourseRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
    }
}
