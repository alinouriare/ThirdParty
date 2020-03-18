 using Contracts.Courses;
using Contracts.Studnts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IUnitOfWork
    {

        IStudentRepository StudentRepository { get; set; }

        ICourseRepository CourseRepository { get; set; }

        void Save();

    }
}
