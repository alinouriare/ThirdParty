using Contracts.Studnts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessEF.Students
{
    public class StudentRepository : IStudentRepository
    {

        private readonly StoreDbContext storeDbContext;

        public StudentRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
    }
}
