using Intermediate.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate.Repositories
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly EmployeeContext _employeeContext;
        public UnitOfWork(EmployeeContext context)
        {
            _employeeContext = context;
        }
        public int Complete()
        {
            return _employeeContext.SaveChanges();
        }

        public void Dispose()
        {
            _employeeContext.Dispose();

        }
    }
}
