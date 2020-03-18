using Contracts;
using Contracts.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Courses
{
    public class AddCourseService : IAddCourseService
    {
        private readonly IUnitOfWork unitOfWork;
        public AddCourseService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Execute()
        {
            unitOfWork.Save();
        }
    }
}
