using Contracts;
using Contracts.Courses;
using Contracts.Studnts;
using DataAccessEF.Courses;
using DataAccessEF.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessEF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext storeDbContext;

        public UnitOfWork(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
        public IStudentRepository StudentRepository { get => new StudentRepository(storeDbContext); set => throw new NotImplementedException(); }
        public ICourseRepository CourseRepository { get =>  new CourseRepository(storeDbContext); set => throw new NotImplementedException(); }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
